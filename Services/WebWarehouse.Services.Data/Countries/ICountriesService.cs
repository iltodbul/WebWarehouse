namespace WebWarehouse.Services.Data.Countries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICountriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);
    }
}
