using System.Collections.Generic;
using WebWarehouse.Web.ViewModels.Goods;

namespace WebWarehouse.Services.Data.Goods
{

    using WebWarehouse.Data.Common.Repositories;
    using WebWarehouse.Data.Models;

    public class GoodsService : IGoodsService
    {
        private readonly IDeletableEntityRepository<Good> goodsRepository;
        private readonly IDeletableEntityRepository<Measure> measureRepository;

        public GoodsService(IDeletableEntityRepository<Good> goodsRepository, IDeletableEntityRepository<Measure> measureRepository)
        {
            this.goodsRepository = goodsRepository;
            this.measureRepository = measureRepository;
        }

        public int Add(GoodInputModel inputModel)
        {
            var good = new Good()
            {
                SKU = inputModel.SKU,
                Barcode = inputModel.Barcode,
                Name = inputModel.Name,
                MeasureId = inputModel.MeasureId,
                DeliveryPrice = inputModel.DeliveryPrice,
                SalePrice = inputModel.SalePrice,
                Discount = inputModel.Discount,
                Quantity = inputModel.Quantity,
            };

            this.goodsRepository.AddAsync(good);
            this.goodsRepository.SaveChangesAsync();
            return good.Id;
        }

        public IEnumerable<GoodViewModel> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
