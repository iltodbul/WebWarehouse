namespace WebWarehouse.Data.Seeding.CustomSeeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using WebWarehouse.Data.Models;

    public class GoodsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Goods.Any())
            {
                return;
            }

            var goodsCollection = new List<Good>();

            for (var i = 1; i <= 10; i++)
            {
                var goods = new Good
                {
                    SKU = $"TEST{i * 100}",
                    Barcode = i < 10 ? $"380{i * 111}" : $"380{i * 11}",
                    Name = $"Good {i}",
                    MeasureId = i % 2 == 0 ? 1 : 2,
                    Quantity = 2 * i,
                    DeliveryPrice = i,
                    SalePrice = i * 0.5M,
                    Discount = 0,
                };
                goodsCollection.Add(goods);
            }

            await dbContext.Goods.AddRangeAsync(goodsCollection);
            await dbContext.SaveChangesAsync();
        }
    }
}
