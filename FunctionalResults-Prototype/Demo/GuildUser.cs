using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo
{
    public interface IGuildUser
    {
        ulong Id { get; }

        IGuild Guild { get; }

        IReadOnlyCollection<ulong> RoleIds { get; }

        Task AddRoleAsync(IRole role, RequestOptions options = null);
    }
}
