namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class PartnersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Partners.Any())
            {
                return;
            }

            var city = dbContext.Cities.First();
            var country = dbContext.Countries.First();

            var partners = new Partner[]
            {
                new Partner
                {
                    Name = "Partner1 OOD",
                    ManagerFullName = "A Manager Full Name",
                    EIK = 123456789,
                    Address = "Address Partner 1",
                    CountryId = country.Id,
                    CityId = city.Id,
                    IsClient = true,
                    IsProvider = true,
                },
                new Partner
                {
                    Name = "Partner2 OOD",
                    ManagerFullName = "B Manager Full Name",
                    EIK = 987654321,
                    Address = "Address Partner 2",
                    CountryId = country.Id,
                    CityId = city.Id,
                    IsClient = false,
                    IsProvider = true,
                },
            };

            await dbContext.Partners.AddRangeAsync(partners);
            await dbContext.SaveChangesAsync();
        }
    }
}
