using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebWarehouse.Data.Models
{
    public class Transfer
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string OutWarehouseId { get; set; }

        //[ForeignKey(nameof(Warehouse))]
        //public Warehouse OutWarehouse { get; set; }

        //public string InWarehouseId { get; set; }

        //[ForeignKey(nameof(Warehouse))]
        //public Warehouse InWarehouse { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Good> TransferGoods { get; set; } = new HashSet<Good>();
    }
}
