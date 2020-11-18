using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebWarehouse.Web.Controllers
{
    public class DeliveriesController : BaseController
    {

        public async Task<IActionResult> Create()
        {

            return this.View();
        }
    }
}
