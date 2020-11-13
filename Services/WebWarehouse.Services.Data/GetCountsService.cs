namespace WebWarehouse.Services.Data
{
    using System.Linq;

    using WebWarehouse.Data.Common.Repositories;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Country> countryRepository;
        private readonly IDeletableEntityRepository<City> cityRepository;
        private readonly IDeletableEntityRepository<Setting> settingRepository;

        public GetCountsService(
            IDeletableEntityRepository<Country> countryRepository,
            IDeletableEntityRepository<City> cityRepository,
            IDeletableEntityRepository<Setting> settingRepository)
        {
            this.countryRepository = countryRepository;
            this.cityRepository = cityRepository;
            this.settingRepository = settingRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                CountriesCount = this.countryRepository.All().Count(),
                CitiesCount = this.cityRepository.All().Count(),
                SettingsCount = this.settingRepository.All().Count(),
            };

            return data;
        }
    }
}
