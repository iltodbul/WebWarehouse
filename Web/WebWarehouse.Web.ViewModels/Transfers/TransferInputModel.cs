namespace WebWarehouse.Web.ViewModels.Transfers
{
    using System;
    using System.Collections.Generic;

    using WebWarehouse.Data.Models;

    public class TransferInputModel
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string OutWarehouseId { get; set; }

        public string InWarehouseId { get; set; }

        public string UserId { get; set; }

        public ICollection<int> TransferGoods { get; set; } = new HashSet<int>();
    }
}
