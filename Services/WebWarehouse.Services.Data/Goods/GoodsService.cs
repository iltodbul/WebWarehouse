﻿namespace WebWarehouse.Services.Data.Goods
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WebWarehouse.Data.Common.Repositories;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;
    using WebWarehouse.Web.ViewModels.Goods;

    public class GoodsService : IGoodsService
    {
        private readonly IDeletableEntityRepository<Good> goodsRepository;
        private readonly IDeletableEntityRepository<Measure> measureRepository;

        public GoodsService(IDeletableEntityRepository<Good> goodsRepository, IDeletableEntityRepository<Measure> measureRepository)
        {
            this.goodsRepository = goodsRepository;
            this.measureRepository = measureRepository;
        }

        public async Task<int> AddAsync(GoodInputModel inputModel)
        {
            var good = new Good()
            {
                SKU = inputModel.SKU,
                Barcode = inputModel.Barcode,
                Name = inputModel.Name,
                DeliveryPrice = inputModel.DeliveryPrice,
                SalePrice = inputModel.SalePrice,
                Discount = inputModel.Discount,
                Quantity = inputModel.Quantity,
                MeasureId = inputModel.MeasureId,
            };

            await this.goodsRepository.AddAsync(good);
            await this.goodsRepository.SaveChangesAsync();
            return good.Id;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var goods = await this.goodsRepository.All()
                .To<T>()
                .ToListAsync();
            return goods;
        }
    }
}
