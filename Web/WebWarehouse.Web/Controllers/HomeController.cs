using System.Linq;
using WebWarehouse.Data;
using WebWarehouse.Web.ViewModels.Home;

namespace WebWarehouse.Web.Controllers
{
    using System.Diagnostics;

    using WebWarehouse.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                CountriesCount = this.dbContext.Countries.Count(),
                CitiesCount = this.dbContext.Cities.Count(),
                SettingsCount = this.dbContext.Settings.Count(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
