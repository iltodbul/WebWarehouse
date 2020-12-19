namespace WebWarehouse.Web.ViewModels.Common.SelectLists
{
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class GoodsSelectListViewModel : IMapFrom<Good>
    {
        public string Name { get; set; }

        public double Quantity { get; set; }
    }
}
