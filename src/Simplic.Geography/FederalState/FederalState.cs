using System;


namespace Simplic.Geography
{
    public class FederalState
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        //In which Country is the federal state
        public Guid CountryId { get; set; }
    }
}
