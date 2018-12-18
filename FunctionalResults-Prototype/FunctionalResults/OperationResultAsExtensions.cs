namespace FunctionalResults
{
    public static class OperationResultAsExtensions
    {
        public static OperationResult<TNext> AsFailure<TNext>(this OperationResult prevOperationResult)
            => OperationResult<TNext>.FromError(
                prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .Error);
    }
}
