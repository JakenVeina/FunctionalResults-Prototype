using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public interface IAuthorizationService
    {
        ulong? CurrentUserId { get; }

        Task<IOperationResult> RequireClaimsAsync(params AuthorizationClaim[] claims);

        Task<IOperationResult> RequireRankOverSubjectAsync(ulong guildId, ulong subjectId);
    }
}
