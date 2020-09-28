using Open.Nat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UPnPTest
{
	public class NatDeviceWrapper
	{
		public readonly NatDevice Device;
		public readonly IPAddress ExternalIP;
		public readonly PortMapper Type;
		public readonly string TypeName;

		public NatDeviceWrapper(NatDevice device, IPAddress externalIP, PortMapper type)
		{
			this.Device = device;
			this.ExternalIP = externalIP;
			this.Type = type;
			this.TypeName = Type == PortMapper.Upnp ? "UPnP" : "NAT-PMP";
		}

		public override string ToString()
		{
			return ExternalIP + " (" + TypeName + ")";
		}
	}
}
