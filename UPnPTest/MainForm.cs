using Mono.Nat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPnPTest
{
	public partial class MainForm : Form
	{
		StreamWriter logWriter = new StreamWriter(new FileStream("Errors.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
		public MainForm()
		{
			Mono.Nat.Logging.Logger.Factory = className => new Mono.Nat.Logging.TextLogger(logWriter, className);
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			NatUtility.DeviceFound += NatUtility_DeviceFound;
			btnRescan_Click(sender, e);
		}

		private void NatUtility_DeviceFound(object sender, DeviceEventArgs e)
		{
			NatDeviceWrapper dev = new NatDeviceWrapper(e.Device, e.Device.GetExternalIP(), e.Device.NatProtocol);
			AddListItem(dev);
		}

		private void AddListItem(NatDeviceWrapper dev)
		{
			if (lbNatDevices.InvokeRequired)
				lbNatDevices.Invoke((Action<NatDeviceWrapper>)AddListItem, dev);
			else
			{
				lbNatDevices.Items.Add(dev);
				if (lbNatDevices.Items.Count == 1)
					lbNatDevices.SelectedIndex = 0;
			}
		}

		private void btnRescan_Click(object sender, EventArgs e)
		{
			try
			{
				StopDiscovery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
			lbNatDevices.Items.Clear();
			NatUtility.StartDiscovery(NatProtocol.Upnp, NatProtocol.Pmp);
		}

		private void btnOpenSelected_Click(object sender, EventArgs e)
		{
			if (lbNatDevices.SelectedItem is NatDeviceWrapper)
			{
				DeviceForm df = new DeviceForm((NatDeviceWrapper)lbNatDevices.SelectedItem);
				df.Owner = this;
				df.StartPosition = FormStartPosition.CenterParent;
				df.ShowDialog();
			}
		}
		private void StopDiscovery()
		{
			Thread thr = new Thread(() =>
			{
				try
				{
					NatUtility.StopDiscovery();
				}
				catch { }
			});
			thr.Name = "Stop Discovery";
			thr.IsBackground = true;
			thr.Start();
			if (!thr.Join(1000))
			{
				thr.Abort();
				throw new Exception("Unable to stop discovery in a timely manner.");
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				StopDiscovery();
			}
			catch { }
		}
	}
}
