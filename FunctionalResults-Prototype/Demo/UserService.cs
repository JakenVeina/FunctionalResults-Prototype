using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public interface IUserService
    {
        Task<IOperationResult<IGuildUser>> GetGuildUser(ulong guildId, ulong userId);
    }
}
