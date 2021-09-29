using System;
using System.Collections.Generic;

namespace Simplic.Geography
{
    public class FederalState : IEquatable<FederalState>, IEqualityComparer<FederalState>
    {
        public static bool operator ==(FederalState left, FederalState right)
        {
            return (left is null && right is null) || (!(left is null) && left.Equals(right));
        }

        public static bool operator !=(FederalState left, FederalState right)
        {
            return (left is null && right is null) ||  (!(left is null) && !left.Equals(right));
        }

        public Guid Guid { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        //In which Country is the federal state
        public Guid CountryId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is FederalState _other)
                return _other.Guid == Guid;

            return false;
        }

        public bool Equals(FederalState other)
        {
            return other?.Guid == Guid;
        }

        public bool Equals(FederalState x, FederalState y)
        {
            return x?.Guid == y?.Guid;
        }

        public override int GetHashCode()
        {
            return Guid.GetHashCode();
        }

        public int GetHashCode(FederalState obj)
        {
            return obj?.Guid.GetHashCode() ?? 0;
        }
    }
}
