namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using WebWarehouse.Data.Common.Models;

    public class Transfer : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(OutWarehouse))]
        public string OutWarehouseId { get; set; }

        public Warehouse OutWarehouse { get; set; }

        [ForeignKey(nameof(InWarehouse))]
        public string InWarehouseId { get; set; }

        public Warehouse InWarehouse { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Good> TransferGoods { get; set; } = new HashSet<Good>();
    }
}
