using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWarehouse.Data.Models;

namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    public class MeasureSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Measures.Any())
            {
                return;
            }

            var measures = new Measure[]
            {
                new Measure
                {
                    Name = "Kg",
                },
                new Measure
                {
                    Name = "Piece",
                },
            };

            await dbContext.Measures.AddRangeAsync(measures);
            await dbContext.SaveChangesAsync();
        }
    }
}
