using Microsoft.EntityFrameworkCore;
using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Infrastructure.Data.Context;
using Petconnect.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petconnect.Infrastructure.Data.Implementations; 
public class EvaluationImplementation : BaseRepository<EvaluationEntity>, IEvaluationRepository {
    private DbSet<EvaluationEntity> _dataset;

    public EvaluationImplementation(DataContext context) : base(context) {
        _dataset = context.Set<EvaluationEntity>();
    }

    public async Task<List<EvaluationEntity>> GetAllByServiceProvider(Guid id) {
        try {
            var queryResult = await _dataset
                .Include(e => e.UserWhoRequested)
                .Include(e => e.Service)
                .Where(e => e.Service != null && e.Service.ServiceProviderId == id)
                .ToListAsync();

            return queryResult;
        }
        catch (Exception expection) {
            throw;
        }
    }
}
