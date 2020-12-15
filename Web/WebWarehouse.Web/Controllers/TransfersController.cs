﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Data.Transfers;
using WebWarehouse.Services.Data.Warehouses;
using WebWarehouse.Web.ViewModels.Common.SelectLists;
using WebWarehouse.Web.ViewModels.Transfers;

namespace WebWarehouse.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class TransfersController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ITransfersService transfersService;
        private readonly IWarehousesService warehousesService;

        public TransfersController(
            UserManager<ApplicationUser> userManager,
            ITransfersService transfersService,
            IWarehousesService warehousesService)
        {
            this.userManager = userManager;
            this.transfersService = transfersService;
            this.warehousesService = warehousesService;
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
            var warehouses = await this.warehousesService.GetAllAsync<WarehouseSelectListViewModel>();
            this.ViewData["Warehouses"] = new SelectList(warehouses, "Id", "Name");
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
