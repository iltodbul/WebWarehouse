using System;
using System.Collections.Generic;
using System.Text;

namespace WebWarehouse.Web.ViewModels.Goods
{
    public class GoodListViewModel
    {
        public IEnumerable<GoodViewModel> Goods { get; set; }
    }
}
