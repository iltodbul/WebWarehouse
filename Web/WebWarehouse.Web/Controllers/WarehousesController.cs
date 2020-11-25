namespace WebWarehouse.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class WarehousesController : BaseController
    {
        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
