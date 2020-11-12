namespace WebWarehouse.Data.Models
{
    using WebWarehouse.Data.Common.Models;

    public class Good : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public int MeasureId { get; set; }

        public Measure Measure { get; set; }

        public double Quantity { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal SalePrice { get; set; }

        public double Discount { get; set; }
    }
}
