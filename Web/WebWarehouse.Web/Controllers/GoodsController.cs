namespace WebWarehouse.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using WebWarehouse.Services.Data.Goods;
    using WebWarehouse.Web.ViewModels.Goods;

    public class GoodsController : BaseController
    {
        private readonly IGoodsService goodsService;

        public GoodsController(IGoodsService goodsService)
        {
            this.goodsService = goodsService;
        }

        public IActionResult All()
        {
            return this.View();
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GoodInputModel model)
        {
            // TODO: Authentication and Authorization
            //var data = new GoodInputModel()
            //{
            //    SKU = model.SKU,
            //    Barcode = model.Barcode,
            //    Name = model.Name,
            //    MeasureId = model.MeasureId,
            //    DeliveryPrice = model.DeliveryPrice,
            //    SalePrice = model.SalePrice,
            //    Discount = model.Discount,
            //    Quantity = model.Quantity,
            //};

            var goodId = await this.goodsService.AddAsync(model);
            return this.Redirect("All");
        }
    }
}
