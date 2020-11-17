namespace WebWarehouse.Services.Data.Measures
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMeasuresService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);
    }
}
