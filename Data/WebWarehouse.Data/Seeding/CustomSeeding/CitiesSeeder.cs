namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Data.Seeding.DTO;

    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var inputJson = await File.ReadAllTextAsync(@"..\..\Data\WebWarehouse.Data\Seeding\Json\bgCities.json");

            var citiesDto = JsonConvert.DeserializeObject<CityDto[]>(inputJson);
            var cities = new List<City>();
            foreach (var cityDto in citiesDto)
            {
                var city = new City()
                {
                    Name = cityDto.Name,
                };
                await dbContext.AddAsync(city);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
