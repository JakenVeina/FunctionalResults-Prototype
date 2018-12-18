using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public interface IUserService
    {
        Task<OperationResult<IGuildUser>> GetGuildUser(ulong guildId, ulong userId);
    }
}
