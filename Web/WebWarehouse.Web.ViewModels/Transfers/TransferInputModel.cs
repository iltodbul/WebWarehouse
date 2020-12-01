﻿namespace WebWarehouse.Web.ViewModels.Transfers
{
    using System;
    using System.Collections.Generic;

    using WebWarehouse.Data.Models;

    public class TransferInputModel
    {
        public int Number { get; set; } //???

        public DateTime Date = DateTime.UtcNow; // TODO Data picker if I have time.

        public string OutWarehouseId { get; set; }

        public string InWarehouseId { get; set; }

        public ICollection<int> TransferGoods { get; set; } = new HashSet<int>(); // TODO How to add goods in this collection?
    }
}
