using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebWarehouse.Data.Common.Repositories;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Mapping;

namespace WebWarehouse.Services.Data.Cities
{
    public class CitiesService : ICitiesService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;

        public CitiesService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<City> cities = this.citiesRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                cities = cities.Take(count.Value);
            }

            return await cities.To<T>().ToListAsync();
        }
    }
}
