using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo
{
    public interface IDesignatedRoleService
    {
        Task<IReadOnlyCollection<DesignatedRoleMappingBrief>> SearchDesignatedRolesAsync(DesignatedRoleMappingSearchCriteria searchCriteria);
    }
}
