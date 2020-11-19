using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebWarehouse.Data.Common.Repositories;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Mapping;

namespace WebWarehouse.Services.Data.Countries
{
    public class CountriesService : ICountriesService
    {
        private readonly IDeletableEntityRepository<Country> countryRepository;

        public CountriesService(IDeletableEntityRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Country> countries = this.countryRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                countries = countries.Take(count.Value);
            }

            return await countries.To<T>().ToListAsync();
        }
    }
}
