using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class InfractionSearchCriteria
    {
        public ulong? GuildId { get; set; }

        public IReadOnlyCollection<InfractionType> Types { get; set; }

        public ulong? SubjectId { get; set; }

        public DateTimeOffsetRange? CreatedRange { get; set; }

        public ulong? CreatedById { get; set; }

        public DateTimeOffsetRange? ExpiresRange { get; set; }

        public bool? IsRescinded { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
