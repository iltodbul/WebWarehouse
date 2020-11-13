using System;
using System.Collections.Generic;
using System.Text;
using WebWarehouse.Data.Models;

namespace WebWarehouse.Web.ViewModels.Goods
{
    public class GoodViewModel
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public string Measure { get; set; }

        public double Quantity { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal SalePrice { get; set; }

        public double Discount { get; set; }
    }
}
