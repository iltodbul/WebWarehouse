namespace WebWarehouse.Services.Data.Measures
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WebWarehouse.Data.Common.Repositories;
    using WebWarehouse.Data.Models;
    using WebWarehouse.Services.Mapping;

    public class MeasuresService : IMeasuresService
    {
        private readonly IDeletableEntityRepository<Measure> measuresRepository;

        public MeasuresService(IDeletableEntityRepository<Measure> measuresRepository)
        {
            this.measuresRepository = measuresRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Measure> measures = this.measuresRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                measures = measures.Take(count.Value);
            }

            return await measures.To<T>().ToListAsync();
        }
    }
}
