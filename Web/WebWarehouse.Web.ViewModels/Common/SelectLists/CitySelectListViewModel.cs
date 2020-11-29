namespace WebWarehouse.Web.ViewModels.Common.SelectLists
{

    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class CitySelectListViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
