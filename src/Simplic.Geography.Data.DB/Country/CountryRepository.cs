using Simplic.Cache;
using Simplic.Data;
using Simplic.Data.Sql;
using Simplic.Sql;
using System;
using System.Collections.Generic;


namespace Simplic.Geography.Data.DB
{
    public class CountryRepository : SqlRepositoryBase<Guid, Country>, ICountryRepository
    {
        private readonly ISqlService sqlService;

        public CountryRepository(ISqlService sqlService, ISqlColumnService sqlColumnService, ICacheService cacheService)
            : base(sqlService, sqlColumnService, cacheService)
        {
            this.sqlService = sqlService; 
        }
        
        /// <summary>
        /// Gets the guid of the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Guid GetId(Country obj) => obj.Guid;
        
        /// <summary>
        /// Overrides the table name to "Country"
        /// </summary>
        public override string TableName => "Country";

        /// <summary>
        /// Overrides the primary key column to "Guid"
        /// </summary>
        public override string PrimaryKeyColumn => "Guid";

        
    }
}
