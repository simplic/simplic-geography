using System;
using System.Collections.Generic;

namespace Simplic.Geography.Service
{
    public class FederalStateService : IFederalStateService
    {
        private readonly IFederalStateRepository federalStateRepository;

        public FederalStateService(IFederalStateRepository federalStateRepository)
        {
            this.federalStateRepository = federalStateRepository;
        }

        /// <summary>
        /// Deletes the federal state 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Delete(FederalState obj)
        {
            return federalStateRepository.Delete(obj);
        }
        /// <summary>
        /// Deletes the federal state based on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Guid id) => federalStateRepository.Delete(id);
        /// <summary>
        /// Gets the federal state based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FederalState Get(Guid id)
        {
            return federalStateRepository.Get(id);
        }
        /// <summary>
        /// Gets the enumrable of federal states
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FederalState> GetAll()
        {
            return federalStateRepository.GetAll();
        }

        public IEnumerable<FederalState> GetByCountry(Guid countryId)
        {
            return federalStateRepository.GetByCountry(countryId);
        }
        

        /// <summary>
        /// Saves the federal state based on the object/poco
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Save(FederalState obj)
        {
            return federalStateRepository.Save(obj);
        }
    }
}
