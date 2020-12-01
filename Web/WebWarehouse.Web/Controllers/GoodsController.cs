using Microsoft.AspNetCore.Identity;
using WebWarehouse.Data.Models;

namespace WebWarehouse.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using WebWarehouse.Services.Data.Goods;
    using WebWarehouse.Services.Data.Measures;
    using WebWarehouse.Web.ViewModels.Common.SelectLists;
    using WebWarehouse.Web.ViewModels.Goods;

    public class GoodsController : BaseController
    {
        private readonly IGoodsService goodsService;
        private readonly IMeasuresService measuresService;
        private readonly UserManager<ApplicationUser> userManager;

        public GoodsController(
            IGoodsService goodsService,
            IMeasuresService measuresService,
            UserManager<ApplicationUser> userManager)
        {
            this.goodsService = goodsService;
            this.measuresService = measuresService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> All()
        {
            var viewModel = new GoodListViewModel()
            {
                Goods = await this.goodsService.GetAllAsync<GoodViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Add()
        {
            var measures = await this.measuresService.GetAllAsync<MeasureSelectListViewModel>();
            this.ViewData["Measures"] = new SelectList(measures, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GoodInputModel model)
        {
            // TODO: Authentication and Authorization
            var goodId = await this.goodsService.AddAsync(model);
            return this.Redirect("All");
        }
    }
}
