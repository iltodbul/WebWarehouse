using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebWarehouse.Web.Controllers
{
    public class MeasuresController : BaseController
    {

        public async Task<IActionResult> Create()
        {

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, string name)
        {

            return this.View();
        }
    }
}
