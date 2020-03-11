using System;

namespace Simplic.Geography
{
    public class Country
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public Guid NameGuid { get; set; }

        public string IsoCode { get; set; }

        public string IsoCode_Alpha3 { get; set; }

        public string IsoCode_Numeric { get; set; }

        public int  ZipCodeLength { get; set; }


    }
}
