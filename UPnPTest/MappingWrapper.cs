using Mono.Nat;
using System;

namespace UPnPTest
{
	public class MappingWrapper : IComparable, IComparable<MappingWrapper>
	{
		public Mapping mapping;

		public MappingWrapper(Mapping mapping)
		{
			this.mapping = mapping;
		}


		public int CompareTo(object obj)
		{
			if (obj is MappingWrapper)
				return CompareWith(obj as MappingWrapper);
			else
				return 1;
		}

		public int CompareTo(MappingWrapper other)
		{
			return CompareWith(other);
		}
		private int CompareWith(MappingWrapper other)
		{
			if (other == null)
				return 1;
			int diff = mapping.Protocol.CompareTo(other.mapping.Protocol);
			if (diff == 0)
				diff = mapping.PublicPort.CompareTo(other.mapping.PublicPort);
			if (diff == 0)
				diff = mapping.PrivatePort.CompareTo(other.mapping.PrivatePort);
			if (diff == 0)
				diff = mapping.Lifetime.CompareTo(other.mapping.Lifetime);
			if (diff == 0)
				diff = string.CompareOrdinal(mapping.Description, other.mapping.Description);
			return diff;
		}
		public override bool Equals(object obj)
		{
			return CompareTo(obj) == 0;
		}
		public override int GetHashCode()
		{
			return mapping.Protocol.GetHashCode() ^ mapping.PublicPort.GetHashCode() ^ mapping.PrivatePort.GetHashCode() ^ mapping.Lifetime.GetHashCode() ^ mapping.Description.GetHashCode();
		}
		public override string ToString()
		{
			return mapping.Protocol + " " + mapping.PublicPort + " -> " + mapping.PrivatePort + " (Lifetime: " + mapping.Lifetime + " sec)" + (!string.IsNullOrWhiteSpace(mapping.Description) ? " - " + mapping.Description : "");
		}
	}
}