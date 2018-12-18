using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo
{
    public interface IGuild
    {
        Task AddBanAsync(ulong userId, int pruneDays = 0, string reason = null, RequestOptions options = null);

        Task<IReadOnlyCollection<IBan>> GetBansAsync(RequestOptions options = null);

        IRole GetRole(ulong id);
    }
}
