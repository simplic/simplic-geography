using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Geography.Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="countryRepository"></param>
        public CountryService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        /// <summary>
        /// Deletes the country based on the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Delete(Country obj)
        {
            return countryRepository.Delete(obj);
        }

        /// <summary>
        /// Deletes the country based on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Guid id)
        {
            return countryRepository.Delete(id);
        }

        /// <summary>
        /// Get the country based on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Country Get(Guid id)
        {
            return countryRepository.Get(id);
        }

        /// <summary>
        /// Gets all countries 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Country> GetAll()
        {
            return countryRepository.GetAll();
        }

        /// <summary>
        /// Saves the country based on the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Save(Country obj)
        {
            return countryRepository.Save(obj);
        }
    }
}
