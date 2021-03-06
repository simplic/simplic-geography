﻿using Simplic.Cache;
using Simplic.Data.Sql;
using Simplic.Sql;
using System;
using System.Collections.Generic;

namespace Simplic.Geography.Data.DB
{
    public class FederalStateRepository : SqlRepositoryBase<Guid, FederalState>, IFederalStateRepository
    {
        private readonly ISqlService sqlService;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sqlService"></param>
        /// <param name="sqlColumnService"></param>
        /// <param name="cacheService"></param>
        public FederalStateRepository(ISqlService sqlService, ISqlColumnService sqlColumnService, ICacheService cacheService)
            : base(sqlService, sqlColumnService, cacheService)

        {
            this.sqlService = sqlService;
        }

        public IEnumerable<FederalState> GetByCountry(Guid countryId)
        {
            return base.GetAllByColumn(nameof(FederalState.CountryId), countryId);
        }

        /// <summary>
        /// Override the getid method to return the guid of the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Guid GetId(FederalState obj) => obj.Guid;



        /// <summary>
        /// Override the table name to fit the database
        /// </summary>
        public override string TableName => "Federal_State";

        /// <summary>
        /// Override the primary key column to the value
        /// </summary>
        public override string PrimaryKeyColumn => "Guid";
    }
}
