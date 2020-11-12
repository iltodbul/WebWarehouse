namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class CountriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countries.Any())
            {
                return;
            }

            var countries = new Country[]
            {
                new Country
                {
                    Name = "Bulgaria",
                },
                new Country
                {
                    Name = "Spain",
                },
            };

            await dbContext.Countries.AddRangeAsync(countries);
            await dbContext.SaveChangesAsync();
        }
    }
}
