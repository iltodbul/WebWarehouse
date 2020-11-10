namespace WebWarehouse.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Good
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }

        public double Quantity { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal SalePrice { get; set; }

        public double Discount { get; set; }
    }
}
