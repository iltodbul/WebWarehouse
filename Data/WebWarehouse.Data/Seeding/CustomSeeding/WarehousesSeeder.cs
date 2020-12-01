namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WebWarehouse.Data.Models;

    public class WarehousesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Warehouses.Any())
            {
                return;
            }

            var city = await dbContext.Cities.FirstAsync();
            var country = dbContext.Countries.First();
            var company = dbContext.Companies.First();
            var goodsCollection = await dbContext.Goods.ToListAsync();

            var warehouses = new Warehouse[]
            {
                new Warehouse
                {
                    Name = "Warehouse 1",
                    Address = "Address Warehouse 1",
                    CountryId = country.Id,
                    CityId = city.Id,
                    CompanyId = company.Id,
                    Goods = goodsCollection,
                },
                new Warehouse
                {
                    Name = "Warehouse 2",
                    Address = "Address Warehouse 2",
                    CountryId = country.Id,
                    CityId = city.Id,
                    CompanyId = company.Id,
                },
            };

            await dbContext.Warehouses.AddRangeAsync(warehouses);
            await dbContext.SaveChangesAsync();
        }
    }
}
