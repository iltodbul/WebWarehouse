namespace WebWarehouse.Web.ViewModels.Goods
{
    using AutoMapper;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class GoodViewModel : IMapFrom<Good>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public string Measure { get; set; }

        public double Quantity { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal SalePrice { get; set; }

        public string MeasureName { get; set; }

        public string WarehouseName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Measure, GoodViewModel>().ForMember(
                m => m.MeasureName,
                opt => opt.MapFrom(x => x.Name));

            configuration.CreateMap<Warehouse, GoodViewModel>().ForMember(
                m => m.WarehouseName,
                opt => opt.MapFrom(x => x.Name));
        }
    }
}
