namespace WebWarehouse.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class SalesController : BaseController
    {
        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
