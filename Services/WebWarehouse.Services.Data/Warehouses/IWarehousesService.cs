namespace WebWarehouse.Services.Data.Warehouses
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IWarehousesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);
    }
}
