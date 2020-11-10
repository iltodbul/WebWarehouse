namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Transfer
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue)]
        public int Number { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(OutWarehouse))]
        public string OutWarehouseId { get; set; }
        public Warehouse OutWarehouse { get; set; }

        [ForeignKey(nameof(InWarehouse))]
        public string InWarehouseId { get; set; }
        public Warehouse InWarehouse { get; set; }

        public string UserId { get; set; }

        public  ApplicationUser User { get; set; }

        public virtual ICollection<Good> TransferGoods { get; set; } = new HashSet<Good>();
    }
}
