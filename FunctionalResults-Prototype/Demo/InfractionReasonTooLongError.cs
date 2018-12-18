using System;

using FunctionalResults;

namespace Demo
{
    public class InfractionReasonTooLongError : IOperationError
    {
        public InfractionReasonTooLongError(int actualLength, int maxLength)
        {
            actualLength = (actualLength > 0) ? actualLength
                : throw new ArgumentException("Must be greater than 0", nameof(actualLength));

            maxLength = (maxLength > 0) ? maxLength
                : throw new ArgumentException("Must be greater than 0", nameof(maxLength));
        }

        public int ActualLength { get; }

        public int MaxLength { get; }
    }
}
