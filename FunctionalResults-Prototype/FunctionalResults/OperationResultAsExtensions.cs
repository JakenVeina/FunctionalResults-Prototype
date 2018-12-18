namespace FunctionalResults
{
    public static class OperationResultAsExtensions
    {
        public static IOperationResult<TNext> AsFailure<TNext>(this IOperationResult prevOperationResult)
            => OperationResult<TNext>.FromError(
                prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .Error);
    }
}
