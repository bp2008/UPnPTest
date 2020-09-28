using Mono.Nat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		bool scanning = false;
		public MainForm()
		{
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
			}
		}

		private void btnRescan_Click(object sender, EventArgs e)
		{
			NatUtility.StopDiscovery();
			lbNatDevices.Items.Clear();
			NatUtility.StartDiscovery(NatProtocol.Upnp, NatProtocol.Pmp);
			//if (scanning)
			//	return;
			//try
			//{
			//	scanning = true;
			//	lbNatDevices.Items.Clear();
			//	lblSearching.Visible = true;
			//	btnRescan.Enabled = false;
			//	NatDiscoverer discoverer = new NatDiscoverer();
			//	Task<NatDevice> getUpnpDevice = discoverer.DiscoverDeviceAsync(PortMapper.Upnp, new CancellationTokenSource(3000));
			//	Task<NatDevice> getNatPmpDevice = discoverer.DiscoverDeviceAsync(PortMapper.Pmp, new CancellationTokenSource(3000));
			//	List<Task<NatDevice>> tasks = new List<Task<NatDevice>>();
			//	tasks.Add(getUpnpDevice);
			//	tasks.Add(getNatPmpDevice);
			//	while (tasks.Count > 0)
			//	{
			//		Task<NatDevice> finishedTask = await Task.WhenAny(tasks);
			//		tasks.Remove(finishedTask);
			//		NatDevice device = null;
			//		NatDeviceWrapper dev;
			//		if (finishedTask == getUpnpDevice)
			//		{
			//			try { device = await finishedTask; } catch { }
			//			dev = new NatDeviceWrapper(device, device == null ? null : await device.GetExternalIPAsync(), PortMapper.Upnp);
			//		}
			//		else
			//		{
			//			try { device = await finishedTask; } catch { }
			//			dev = new NatDeviceWrapper(device, device == null ? null : await device.GetExternalIPAsync(), PortMapper.Pmp);
			//		}
			//		if (dev.Device != null)
			//		{
			//			lbNatDevices.Items.Add(dev);
			//		}
			//		else
			//			lbNatDevices.Items.Add("No " + dev.TypeName + " device");
			//	}
			//	lblSearching.Visible = false;
			//}
			//finally
			//{
			//	scanning = false;
			//	btnRescan.Enabled = true;
			//}
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

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			NatUtility.StopDiscovery();
		}
	}
}
