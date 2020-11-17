using System.Collections.Generic;
using System.Threading.Tasks;
using WebWarehouse.Web.ViewModels.Goods;

namespace WebWarehouse.Services.Data.Goods
{
    public interface IGoodsService
    {
        // TODO
        Task<int> AddAsync(GoodInputModel inputModel);

        IEnumerable<GoodViewModel> GetAll();
    }
}
