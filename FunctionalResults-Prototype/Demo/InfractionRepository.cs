using System.Collections.Generic;
using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public interface IInfractionRepository
    {
        Task<IRepositoryTransaction> BeginCreateTransactionAsync();

        Task<IRepositoryTransaction> BeginDeleteTransactionAsync();

        Task<OperationResult<long>> CreateAsync(InfractionCreationData data);

        Task<IReadOnlyCollection<long>> SearchIdsAsync(InfractionSearchCriteria searchCriteria);

        Task<int> TryDeleteAsync(IEnumerable<long> infractionIds, ulong deletedById);
    }
}
