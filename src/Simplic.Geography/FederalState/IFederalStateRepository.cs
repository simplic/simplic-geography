using Simplic.Data;
using System;
using System.Collections.Generic;

namespace Simplic.Geography
{
    public interface IFederalStateRepository : IRepositoryBase<Guid, FederalState>
    {
        IEnumerable<FederalState> GetByCountry(Guid countryId);
    }
}
