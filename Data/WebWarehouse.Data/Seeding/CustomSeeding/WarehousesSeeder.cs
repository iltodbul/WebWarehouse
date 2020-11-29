namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class WarehousesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Warehouses.Any())
            {
                return;
            }

            var city = dbContext.Cities.First();
            var country = dbContext.Countries.First();
            var company = dbContext.Companies.First();

            var warehouses = new Warehouse[]
            {
                new Warehouse
                {
                    Name = "Warehouse 1",
                    Address = "Address Warehouse 1",
                    CountryId = country.Id,
                    CityId = city.Id,
                    CompanyId = company.Id,
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
