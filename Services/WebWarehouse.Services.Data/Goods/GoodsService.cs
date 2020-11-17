using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<GoodViewModel> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
