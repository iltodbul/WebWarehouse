﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebWarehouse.Web.Controllers
{
    public class PartnersController : BaseController
    {

        public async Task<IActionResult> Create()
        {

            return this.View();
        }
    }
}