using Microsoft.EntityFrameworkCore;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Infrastructure.Data.Context;
using Petconnect.Infrastructure.Data.Repositories;

namespace Petconnect.Infrastructure.Data.Implementations {
    public class ServiceImplementation : BaseRepository<ServiceEntity>, IServiceRepository {
        private DbSet<ServiceEntity> _dataset;

        public ServiceImplementation(DataContext context) : base(context) {
            _dataset = context.Set<ServiceEntity>();
        }

        public async Task<List<ServiceEntity>> GetAllRelatedDetails() {
            try {
                var queryResult = await _dataset
                    .Include(service => service.Animals)
                    .Include(service => service.ServiceCategory)
                    .Include(service => service.Evaluations)
                    .Include(service => service.ServiceProvider)
                        .ThenInclude(provider => provider.Addresses)
                    .ToListAsync();
                    
                return queryResult;
            }
            catch (Exception expection) {
                throw;
            }
        }

        public async Task<ServiceEntity> GetAllRelatedDetailsById(Guid id) {
            try {
                var queryResult = await _dataset
                    .Include(service => service.Animals)
                    .Include(service => service.ServiceCategory)
                    .Include(service => service.Evaluations)
                    .Include(service => service.ServiceProvider)
                        .ThenInclude(provider => provider.Addresses)
                    .FirstOrDefaultAsync(service => service.Id == id);

                return queryResult;
            }
            catch (Exception expection) {
                throw;
            }
        }
    }
}
