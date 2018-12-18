using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public interface IAuthorizationService
    {
        ulong? CurrentUserId { get; }

        Task<OperationResult> RequireClaimsAsync(params AuthorizationClaim[] claims);

        Task<OperationResult> RequireRankOverSubjectAsync(ulong guildId, ulong subjectId);
    }
}
