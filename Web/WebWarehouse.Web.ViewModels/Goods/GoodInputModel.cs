using System;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Web.ViewModels.Goods
{
    public class GoodInputModel
    {
        // TODO calculation properties??
        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string SKU { get; set; }

        public string Barcode { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        public int MeasureId { get; set; }

        [Range(0.00, double.MaxValue)]
        public decimal DeliveryPrice { get; set; }

        [Range(0.00, double.MaxValue)]
        public decimal SalePrice { get; set; }

        [Range(0.00, double.MaxValue)]
        public double Quantity { get; set; }
    }
}
