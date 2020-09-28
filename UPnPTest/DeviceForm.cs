using Open.Nat;
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
		}

		private async void btnAddMapping_Click(object sender, EventArgs e)
		{
			Protocol protocol = cbProtocol.SelectedIndex == 0 ? Protocol.Tcp : Protocol.Udp;
			Mapping mapping = new Mapping(protocol, (int)nudInternalPort.Value, (int)nudExternalPort.Value, 0, txtDescription.Text);
			lblStatus.Text = "Adding…";
			try
			{
				await dev.Device.CreatePortMapAsync(mapping);
				lblStatus.Text = "Added";
			}
			catch (Exception ex)
			{
				lblStatus.Text = "Error";
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
