using System.Collections.Generic;
using WebWarehouse.Web.ViewModels.Goods;

namespace WebWarehouse.Services.Data.Goods
{
    public interface IGoodsService
    {
        // TODO
        int Add(GoodInputModel inputModel);

        IEnumerable<GoodViewModel> GetAll();
    }
}
