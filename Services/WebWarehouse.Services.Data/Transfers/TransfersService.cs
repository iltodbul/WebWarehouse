using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using WebWarehouse.Data.Common.Repositories;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Mapping;

namespace WebWarehouse.Services.Data.Transfers
{
    using System;
    using System.Threading.Tasks;

    using WebWarehouse.Web.ViewModels.Transfers;

    public class TransfersService : ITransfersService
    {
        private readonly IDeletableEntityRepository<Warehouse> warehouseRepository;
        private readonly IDeletableEntityRepository<Good> goodsRepository;
        private readonly IDeletableEntityRepository<Transfer> transfersRepository;

        public TransfersService(
            IDeletableEntityRepository<Warehouse> warehouseRepository,
            IDeletableEntityRepository<Good> goodsRepository,
            IDeletableEntityRepository<Transfer> transfersRepository)
        {
            this.warehouseRepository = warehouseRepository;
            this.goodsRepository = goodsRepository;
            this.transfersRepository = transfersRepository;
        }

        public async Task MakeTransfer(TransferInputModel inputModel, string userId)
        {
            var outWarehouseId = inputModel.OutWarehouseId;
            var inWarehouseId = inputModel.InWarehouseId;
            var transferGoods = inputModel.TransferGoods;

        //    foreach (var goods in transferGoods)
        //    {
        //        var outGoodsToChange = this.goodsRepository.All().FirstOrDefault(x => x.Id == goods.Id);

        //        if (outGoodsToChange != null)
        //        {
        //            outGoodsToChange.Quantity -= goods.Quantity;
        //            outGoodsToChange.WarehouseId = outWarehouseId;
        //            this.goodsRepository.Update(outGoodsToChange);
        //        }

        //        var inGoods = new Good
        //        {
        //            SKU = goods.SKU,
        //            Name = goods.Name,
        //            Barcode = goods.Barcode,
        //            MeasureId = goods.MeasureId,
        //            DeliveryPrice = goods.DeliveryPrice,
        //            SalePrice = goods.SalePrice,
        //            Quantity = goods.Quantity,
        //            WarehouseId = inWarehouseId,
        //        };
        //        await this.goodsRepository.AddAsync(inGoods);
        //        await this.goodsRepository.SaveChangesAsync();
        //    }

        //    var transfer = new Transfer
        //    {
        //        Date = inputModel.Date,
        //        InWarehouseId = inWarehouseId,
        //        OutWarehouseId = outWarehouseId,
        //        Number = 0,
        //        TransferGoods = transferGoods,
        //        UserId = userId,
        //    };
        //    await this.transfersRepository.AddAsync(transfer);
        //    await this.transfersRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var transfers = await this.transfersRepository.All()
                .To<T>()
                .ToListAsync();
            return transfers;
        }
    }
}
