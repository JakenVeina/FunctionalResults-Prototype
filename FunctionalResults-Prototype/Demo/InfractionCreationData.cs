using System;

namespace Demo
{
    public class InfractionCreationData
    {
        public ulong GuildId { get; set; }

        public InfractionType Type { get; set; }

        public string Reason { get; set; }

        public TimeSpan? Duration { get; set; }

        public ulong SubjectId { get; set; }

        public ulong CreatedById { get; set; }
    }
}
