namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Delivery
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue)]
        public int Number { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string PartnerId { get; set; }

        public virtual Partner Partner { get; set; }

        [Required]
        public string WarehouseId { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public ICollection<Good> DeliveringGoods { get; set; } = new HashSet<Good>();

        public decimal SumDeliveryPrice { get; set; }

        public decimal DeliveryVAT { get; set; }

        public decimal DeliveryTotalSum { get; set; }
    }
}
