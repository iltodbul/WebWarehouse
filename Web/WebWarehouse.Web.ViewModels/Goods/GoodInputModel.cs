namespace WebWarehouse.Web.ViewModels.Goods
{
    public class GoodInputModel
    {
        // TODO Requirements and constraints and calculation properties.
        public string SKU { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public int MeasureId { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal SalePrice { get; set; }

        public double Quantity { get; set; }
    }
}
