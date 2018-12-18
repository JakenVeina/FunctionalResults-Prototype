using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class DesignatedRoleMappingSearchCriteria
    {
        public long? Id { get; set; }

        public ulong? GuildId { get; set; }

        public ulong? RoleId { get; set; }

        public DesignatedRoleType? Type { get; set; }

        public ulong? CreatedById { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
