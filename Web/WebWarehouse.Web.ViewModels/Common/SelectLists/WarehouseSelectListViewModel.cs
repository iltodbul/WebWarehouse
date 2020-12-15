namespace WebWarehouse.Web.ViewModels.Common.SelectLists
{
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class WarehouseSelectListViewModel : IMapFrom<Warehouse>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
