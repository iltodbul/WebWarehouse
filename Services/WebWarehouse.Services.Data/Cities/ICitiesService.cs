using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebWarehouse.Services.Data.Cities
{
    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);
    }
}
