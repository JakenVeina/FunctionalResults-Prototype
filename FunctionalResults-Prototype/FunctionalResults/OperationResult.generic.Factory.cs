namespace FunctionalResults
{
    public partial class OperationResult<T>
    {
        new public static OperationResult<T> FromError(IOperationError error)
            => new OperationResult<T>(error);

        public static OperationResult<T> FromResult(T value)
            => new OperationResult<T>(value);
    }
}
