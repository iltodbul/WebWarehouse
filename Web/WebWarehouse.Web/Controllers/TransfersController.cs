using Microsoft.AspNetCore.Identity;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Data.Transfers;
using WebWarehouse.Web.ViewModels.Transfers;

namespace WebWarehouse.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class TransfersController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ITransfersService transfersService;

        public TransfersController(UserManager<ApplicationUser> userManager, ITransfersService transfersService)
        {
            this.userManager = userManager;
            this.transfersService = transfersService;
        }

        public async Task<IActionResult> All()
        {
            var viewModel = new TransferListViewModel()
            {
                Transfers = await this.transfersService.GetAllAsync<TransferViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransferInputModel model)
        {
            var userId = this.userManager.GetUserId(this.User);
            await this.transfersService.MakeTransfer(model, userId);

            return this.View();
        }
    }
}
