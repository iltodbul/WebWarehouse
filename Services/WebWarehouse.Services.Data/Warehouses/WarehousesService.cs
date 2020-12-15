namespace WebWarehouse.Services.Data.Warehouses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WebWarehouse.Data.Common.Repositories;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class WarehousesService : IWarehousesService
    {
        private readonly IDeletableEntityRepository<Warehouse> warehousesRepository;

        public WarehousesService(IDeletableEntityRepository<Warehouse> warehousesRepository)
        {
            this.warehousesRepository = warehousesRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Warehouse> warehouses = this.warehousesRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                warehouses = warehouses.Take(count.Value);
            }

            return await warehouses.To<T>().ToListAsync();
        }
    }
}
