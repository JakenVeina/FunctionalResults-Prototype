using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using FunctionalResults;

namespace Demo
{
    public class ModerationService
    {
        public ModerationService(
            IAuthorizationService authorizationService,
            IDesignatedRoleService designatedRoleService,
            IInfractionRepository infractionRepository,
            ISelfUser selfUser,
            IUserService userService)
        {
            AuthorizationService = authorizationService;
            DesignatedRoleService = designatedRoleService;
            InfractionRepository = infractionRepository;
            SelfUser = selfUser;
            UserService = userService;
        }

        public Task<IOperationResult<long>> CreateInfractionAsync(InfractionType type, ulong guildId, ulong subjectId, string reason, TimeSpan? duration)
            => OperationResult.Start
                // Validation
                .Require(!string.IsNullOrWhiteSpace(reason),
                    () => new InfractionReasonMissingError())
                .Require(reason.Length <= 1000,
                    () => new InfractionReasonTooLongError(actualLength: reason.Length, maxLength: 1000))
                // Authorization
                .ContinueOnSuccessAsync(() => AuthorizationService
                    .RequireClaimsAsync(_requiredClaimsByInfractionType[type]))
                .ContinueOnSuccessAsync(() => AuthorizationService
                    .RequireRankOverSubjectAsync(guildId, subjectId))
                // Acquire Guild API
                .ContinueOnSuccessAsync(() => UserService
                    .GetGuildUser(guildId, subjectId))
                // Try perform mute
                .DoOnSuccessWhenAsync(type == InfractionType.Mute,
                    guildUser => DesignatedRoleService
                        // Retrieve mute role
                        .SearchDesignatedRolesAsync(new DesignatedRoleMappingSearchCriteria()
                        {
                            GuildId = guildId,
                            Type = DesignatedRoleType.ModerationMute,
                            IsDeleted = false
                        })
                        .AsSuccessAsync()
                        .RequireOnSuccessAsync(
                            roleMappings => roleMappings.Any(),
                            () => new ModerationMuteRoleNotConfiguredError())
                        .RequireOnSuccessAsync(
                            roleMappings => roleMappings.Count == 1,
                            () => new ModerationMuteRoleMultipleConfigurationsError())
                        .ContinueOnSuccessAsync(roleMappings => roleMappings
                            .First()
                            .Role.Id
                            .AsSuccess())
                        // Verify user is not muted
                        .RequireOnSuccessAsync(
                            roleId => !guildUser.RoleIds.Contains(roleId),
                            () => new ModerationSubjectAlreadyMutedError())
                        // Discord API
                        .ContinueOnSuccessAsync(roleId => guildUser
                            .Guild
                            .GetRole(roleId)
                            .AsSuccess())
                        // Perform mute
                        .BranchOnSuccessAsync(role =>
                            guildUser.AddRoleAsync(role)))
                // Try perform ban
                .DoOnSuccessWhenAsync(type == InfractionType.Ban,
                    guildUser => guildUser.Guild
                        .AsSuccess()
                        // Verify user is not banned
                        .DoOnSuccessAsync(guild => guild
                            .GetBansAsync()
                            .AsSuccessAsync()
                            .RequireOnSuccessAsync(bans => !bans.Any(x => x.User.Id == guildUser.Id),
                                () => new ModerationSubjectAlreadyBannedError()))
                        // Perform ban
                        .BranchOnSuccessAsync(guild =>
                            guild.AddBanAsync(guildUser.Id)))
                // Perform database operations
                .ContinueOnSuccessAsync(async () =>
                {
                    using (var deleteTransaction = await InfractionRepository.BeginDeleteTransactionAsync())
                    using (var createTransaction = await InfractionRepository.BeginCreateTransactionAsync())
                    {
                        return await OperationResult.Start
                            // Delete existing active Mute/Ban infractions, if any, so we can create a new one
                            .BranchWhenAsync((type == InfractionType.Mute) || (type == InfractionType.Ban),
                                () => OperationResult.Start
                                    .ContinueAsync(InfractionRepository.SearchIdsAsync(new InfractionSearchCriteria()
                                    {
                                        GuildId = guildId,
                                        Types = new[] { type },
                                        SubjectId = subjectId,
                                        IsRescinded = false,
                                        IsDeleted = false
                                    }).AsSuccessAsync())
                                    .BranchOnSuccessWhenAsync(bans => bans.Any(),
                                        bans => InfractionRepository
                                            .TryDeleteAsync(
                                                bans,
                                                SelfUser.Id)))
                            // Record new infraction
                            .ContinueOnSuccessAsync(() => InfractionRepository.CreateAsync(new InfractionCreationData()
                            {
                                GuildId = guildId,
                                Type = type,
                                Reason = reason,
                                Duration = duration,
                                SubjectId = subjectId,
                                CreatedById = AuthorizationService.CurrentUserId
                                    ?? SelfUser.Id
                            }))
                            .BranchOnSuccess(() =>
                            {
                                deleteTransaction.Commit();
                                createTransaction.Commit();
                            });
                    }
                });

        internal protected IAuthorizationService AuthorizationService { get; }

        internal protected IDesignatedRoleService DesignatedRoleService { get; }

        internal protected IInfractionRepository InfractionRepository { get; }

        internal protected ISelfUser SelfUser { get; }

        internal protected IUserService UserService { get; }

        private static readonly Dictionary<InfractionType, AuthorizationClaim> _requiredClaimsByInfractionType
            = new Dictionary<InfractionType, AuthorizationClaim>()
            {
                [InfractionType.Notice] = AuthorizationClaim.ModerationNotice,
                [InfractionType.Warning] = AuthorizationClaim.ModerationWarn,
                [InfractionType.Mute] = AuthorizationClaim.ModerationMute,
                [InfractionType.Ban] = AuthorizationClaim.ModerationBan
            };
    }
}
