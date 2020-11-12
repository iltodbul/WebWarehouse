namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var cities = new City[]
            {
                new City
                {
                    Name = "Sofia",
                },
                new City
                {
                    Name = "Varna",
                },
                new City
                {
                    Name = "Burgas",
                },
            };

            foreach (var city in cities)
            {
                await dbContext.AddAsync(city);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
