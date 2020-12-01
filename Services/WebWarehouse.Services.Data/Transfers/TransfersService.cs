using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using WebWarehouse.Data.Common.Repositories;
using WebWarehouse.Data.Models;

namespace WebWarehouse.Services.Data.Transfers
{
    using System;
    using System.Threading.Tasks;

    using WebWarehouse.Web.ViewModels.Transfers;

    public class TransfersService : ITransfersService
    {
        private readonly IDeletableEntityRepository<Warehouse> warehouseRepository;
        private readonly IDeletableEntityRepository<Good> goodsRepository;

        public TransfersService(
            IDeletableEntityRepository<Warehouse> warehouseRepository,
            IDeletableEntityRepository<Good> goodsRepository)
        {
            this.warehouseRepository = warehouseRepository;
            this.goodsRepository = goodsRepository;
        }

        public async Task MakeTransfer(TransferInputModel inputModel)
        {
            var outWarehouseId = inputModel.OutWarehouseId;
            var inWarehouseId = inputModel.InWarehouseId;
            var transferGoodsId = inputModel.TransferGoods;
            var transferGoods = transferGoodsId.Select(id => this.goodsRepository.All().FirstOrDefault(x => x.Id == id)).ToList();

            foreach (var goods in transferGoods)
            {
                var outGoodsToChange = this.goodsRepository.All().FirstOrDefault(x => x.Id == goods.Id);

                if (outGoodsToChange != null)
                {
                    outGoodsToChange.Quantity -= goods.Quantity;
                    outGoodsToChange.WarehouseId = outWarehouseId;
                    this.goodsRepository.Update(outGoodsToChange);
                }

                var inGoods = new Good
                {
                    SKU = goods.SKU,
                    Name = goods.Name,
                    Barcode = goods.Barcode,
                    MeasureId = goods.MeasureId,
                    DeliveryPrice = goods.DeliveryPrice,
                    SalePrice = goods.SalePrice,
                    Quantity = goods.Quantity,
                    WarehouseId = inWarehouseId,
                };
                await this.goodsRepository.AddAsync(inGoods);
                await this.goodsRepository.SaveChangesAsync();

            }

            /*  1. във входящия склад да се добави стоката с определеното количество
                2. в изходящия склад да се коригира количеството на стоката
                3. да се създаде трансфер с необходимите пропъртита. 
            */
            throw new NotImplementedException();
        }
    }
}
