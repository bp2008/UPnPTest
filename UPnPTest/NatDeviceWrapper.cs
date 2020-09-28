using Mono.Nat;
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
		public readonly INatDevice Device;
		public readonly IPAddress ExternalIP;
		public readonly NatProtocol Type;
		public readonly string TypeName;

		public NatDeviceWrapper(INatDevice device, IPAddress externalIP, NatProtocol type)
		{
			this.Device = device;
			this.ExternalIP = externalIP;
			this.Type = type;
			this.TypeName = Type == NatProtocol.Upnp ? "UPnP" : "NAT-PMP";
		}

		public override string ToString()
		{
			return ExternalIP + " (" + TypeName + ")";
		}
	}
}
