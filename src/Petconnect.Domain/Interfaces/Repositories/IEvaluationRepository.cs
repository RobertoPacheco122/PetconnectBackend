using Petconnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petconnect.Domain.Interfaces.Repositories; 
public interface IEvaluationRepository {
    Task<List<EvaluationEntity>> GetAllByServiceProvider(Guid id);
}
