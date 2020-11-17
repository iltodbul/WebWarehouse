namespace WebWarehouse.Services.Data.Goods
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WebWarehouse.Web.ViewModels.Goods;

    public interface IGoodsService
    {
        Task<int> AddAsync(GoodInputModel inputModel);

        // IEnumerable<GoodViewModel> GetAll();
        Task<IEnumerable<T>> GetAllAsync<T>();
    }
}
