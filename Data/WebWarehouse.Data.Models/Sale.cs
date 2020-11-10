namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Sale
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string PartnerId { get; set; }

        public Partner Partner { get; set; }

        public string WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Good> SaleGoods { get; set; } = new HashSet<Good>();

        public decimal SumSalePrice { get; set; }

        public decimal SaleVAT { get; set; }

        public decimal SaleTotalSum { get; set; }
    }
}
