namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class CompanySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Companies.Any())
            {
                return;
            }

            var city = dbContext.Cities.First();
            var country = dbContext.Countries.First();

            var company = new Company
            {
                Name = "My Company OOD",
                ManagerFullName = "Company Manager Full Name",
                EIK = 111222333,
                Address = "Address My Company",
                CountryId = country.Id,
                CityId = city.Id,
            };

            await dbContext.Companies.AddAsync(company);
            await dbContext.SaveChangesAsync();
        }
    }
}
