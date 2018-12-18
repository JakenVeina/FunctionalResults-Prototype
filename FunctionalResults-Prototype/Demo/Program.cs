using System;
using System.Threading.Tasks;

using FunctionalResults;

using Moq;
using Moq.AutoMock;

namespace Demo
{
    public static class Program
    {
        public static async Task Main()
        {
            var autoMocker = new AutoMocker(
                MockBehavior.Strict,
                DefaultValue.Mock);

            autoMocker.GetMock<IAuthorizationService>()
                .Setup(x => x.RequireClaimsAsync(It.IsAny<AuthorizationClaim[]>()))
                .ReturnsAsync(OperationResult.Success);

            autoMocker.GetMock<IAuthorizationService>()
                .Setup(x => x.RequireRankOverSubjectAsync(It.IsAny<ulong>(), It.IsAny<ulong>()))
                .ReturnsAsync(OperationResult.Success);

            autoMocker.GetMock<IAuthorizationService>()
                .Setup(x => x.CurrentUserId)
                .Returns(1);

            autoMocker.GetMock<IUserService>()
                .Setup(x => x.GetGuildUser(It.IsAny<ulong>(), It.IsAny<ulong>()))
                .ReturnsAsync(OperationResult.FromResult(autoMocker.Get<IGuildUser>()));

            autoMocker.GetMock<IDesignatedRoleService>()
                .Setup(x => x.SearchDesignatedRolesAsync(It.IsAny<DesignatedRoleMappingSearchCriteria>()))
                .ReturnsAsync(new[]
                {
                    new DesignatedRoleMappingBrief()
                    {
                        Id = 2,
                        Role = new GuildRoleBrief()
                        {
                            Id = 3,
                            Name = "ModerationMuteRole",
                            Position = 4
                        },
                        Type = DesignatedRoleType.ModerationMute
                    }
                });

            autoMocker.GetMock<IGuildUser>()
                .Setup(x => x.RoleIds)
                .Returns(Array.Empty<ulong>());

            autoMocker.GetMock<IGuildUser>()
                .Setup(x => x.Guild)
                .Returns(autoMocker.Get<IGuild>());

            autoMocker.GetMock<IGuildUser>()
                .Setup(x => x.AddRoleAsync(It.IsAny<IRole>(), It.IsAny<RequestOptions>()))
                .Returns(Task.CompletedTask);

            autoMocker.GetMock<IGuild>()
                .Setup(x => x.GetRole(It.IsAny<ulong>()))
                .Returns(autoMocker.Get<IRole>());

            autoMocker.GetMock<IInfractionRepository>()
                .Setup(x => x.BeginCreateTransactionAsync())
                .ReturnsAsync(new Mock<IRepositoryTransaction>().Object);

            autoMocker.GetMock<IInfractionRepository>()
                .Setup(x => x.BeginDeleteTransactionAsync())
                .ReturnsAsync(new Mock<IRepositoryTransaction>().Object);

            autoMocker.GetMock<IInfractionRepository>()
                .Setup(x => x.SearchIdsAsync(It.IsAny<InfractionSearchCriteria>()))
                .ReturnsAsync(Array.Empty<long>());

            autoMocker.GetMock<IInfractionRepository>()
                .Setup(x => x.CreateAsync(It.IsAny<InfractionCreationData>()))
                .ReturnsAsync(OperationResult.FromResult(5L));

            var moderationService = autoMocker.CreateInstance<ModerationService>();

            var result = await moderationService.CreateInfractionAsync(
                type: InfractionType.Mute,
                guildId: 6,
                subjectId: 7,
                reason: "Test Mute",
                duration: null);

            Console.WriteLine(result.IsSuccess
                ? $"result: {result.Value}"
                : $"result: {result.Error.ToString()}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
