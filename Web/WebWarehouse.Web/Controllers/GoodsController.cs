using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWarehouse.Services.Data.Goods;
using WebWarehouse.Web.ViewModels.Goods;

namespace WebWarehouse.Web.Controllers
{
    public class GoodsController : BaseController
    {
        private readonly IGoodsService goodsService;

        public GoodsController(IGoodsService goodsService)
        {
            this.goodsService = goodsService;
        }

        public IActionResult All()
        {


            return View();
        }

        public IActionResult Add(GoodInputModel model, string test)
        {
            return this.View(model);
        }

        [HttpPost]
        public IActionResult Add(GoodInputModel model)
        {
            return this.View(model);
        }
    }
}
