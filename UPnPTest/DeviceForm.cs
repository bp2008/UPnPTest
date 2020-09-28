using Mono.Nat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPnPTest
{
	public partial class DeviceForm : Form
	{
		public readonly NatDeviceWrapper dev;
		public DeviceForm(NatDeviceWrapper dev)
		{
			this.dev = dev;

			InitializeComponent();

			Text = dev.ToString();
			cbProtocol.SelectedIndex = 0;
			lblStatus.Text = "";
			if (dev.Type == NatProtocol.Pmp)
			{
				lbActiveMappings.Enabled = false;
				btnRefresh.Enabled = btnRefresh.Visible = false;
				btnDeleteSelected.Enabled = btnDeleteSelected.Visible = false;
				btnDeleteAll.Enabled = btnDeleteAll.Visible = false;
				txtDescription.Text = "Not Supported with NAT-PMP";
				txtDescription.Enabled = false;
				lblActiveMappings.Text = "NAT-PMP protocol does not support listing active mappings or setting the Description string.";
			}
		}

		private async void DeviceForm_Load(object sender, EventArgs e)
		{
			btnRefresh_Click(sender, e);
		}

		private async void btnAddMapping_Click(object sender, EventArgs e)
		{
			Protocol protocol = cbProtocol.SelectedIndex == 0 ? Protocol.Tcp : Protocol.Udp;
			string description = txtDescription.Enabled ? SanitizeStringInput(txtDescription.Text) : "";
			if (string.IsNullOrWhiteSpace(description))
				description = "";
			Mapping mapping = new Mapping(protocol, (int)nudInternalPort.Value, (int)nudExternalPort.Value, 0, description);
			lblStatus.Text = "Adding…";
			try
			{
				Mapping result = await dev.Device.CreatePortMapAsync(mapping);
				lblStatus.Text = "Added";
				AddMapping(result);
			}
			catch (MappingException ex)
			{
				if (ex.ErrorCode == ErrorCode.Success)
				{
					lblStatus.Text = "Added w/Error";
					MessageBox.Show(ex.ErrorCode + ": " + ex.ErrorText);
				}
				else
				{
					lblStatus.Text = "Error";
					MessageBox.Show(ex.ErrorCode + ": " + ex.ErrorText);
				}
			}
			catch (Exception ex)
			{
				lblStatus.Text = "Error";
				MessageBox.Show(ex.ToString());
			}
		}

		private void AddMapping(Mapping mapping)
		{
			MappingWrapper wrapper = new MappingWrapper(mapping);
			if (!lbActiveMappings.Items.Contains(wrapper))
				lbActiveMappings.Items.Add(wrapper);
		}

		private async void btnRefresh_Click(object sender, EventArgs e)
		{
			if (!btnRefresh.Enabled)
				return;
			lbActiveMappings.Items.Clear();
			Mapping[] mappings = await dev.Device.GetAllMappingsAsync();
			foreach (Mapping mapping in mappings)
				AddMapping(mapping);
		}

		private async void btnDeleteSelected_Click(object sender, EventArgs e)
		{
			if (!btnDeleteSelected.Enabled)
				return;
			if (lbActiveMappings.SelectedItem is MappingWrapper)
			{
				MappingWrapper wrapper = (MappingWrapper)lbActiveMappings.SelectedItem;
				try
				{
					Mapping result = await dev.Device.DeletePortMapAsync(wrapper.mapping);
					lbActiveMappings.Items.Remove(wrapper);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private async void btnDeleteAll_Click(object sender, EventArgs e)
		{
			if (!btnDeleteAll.Enabled)
				return;
			try
			{
				for(int i = 0; i < lbActiveMappings.Items.Count; i++)
				{
					if (lbActiveMappings.Items[i] is MappingWrapper)
					{
						MappingWrapper wrapper = (MappingWrapper)lbActiveMappings.Items[i];
						Mapping result = await dev.Device.DeletePortMapAsync(wrapper.mapping);
						lbActiveMappings.Items.RemoveAt(i);
						i--;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private string SanitizeStringInput(string str)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in str)
			{
				if (c == '\r' || c == '\n' || c == '\t')
					sb.Append(' ');
				else if (c == ' ' || c == '-' || c == '_')
					sb.Append(c);
				else if (c >= 'a' && c <= 'z')
					sb.Append(c);
				else if (c >= 'A' && c <= 'Z')
					sb.Append(c);
				else if (c >= '0' && c <= '9')
					sb.Append(c);
				else
					sb.Append('?');
			}
			return sb.ToString();
		}
	}
}
