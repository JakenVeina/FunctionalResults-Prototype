using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public interface IOperationResult
    {
        bool IsSuccess { get; }

        bool IsFailure { get; }

        IOperationError Error { get; }
    }

    public class OperationResult : IOperationResult
    {
        public static IOperationResult Success { get; }
            = new OperationResult();

        public static IOperationResult Start
            => Success;

        public static IOperationResult<T> FromResult<T>(T value)
            => new OperationResult<T>(value);

        public static IOperationResult FromError(IOperationError error)
            => new OperationResult(error);

        public static IOperationResult<TResult> Combine<T1, T2, TResult>(IOperationResult<T1> operationResult1, IOperationResult<T2> operationResult2, Func<T1, T2, TResult> combiner)
            => operationResult1.AssertNotNull(nameof(operationResult1)).IsFailure ? OperationResult<TResult>.FromError(operationResult1.Error)
                : operationResult2.AssertNotNull(nameof(operationResult2)).IsFailure ? OperationResult<TResult>.FromError(operationResult2.Error)
                : OperationResult<TResult>.FromResult(combiner.AssertNotNull(nameof(combiner)).Invoke(operationResult1.Value, operationResult2.Value));

        public static async Task<IOperationResult<TResult>> Combine<T1, T2, TResult>(Task<IOperationResult<T1>> operation1, Task<IOperationResult<T2>> operation2, Func<T1, T2, TResult> combiner)
            => Combine(await operation1.AssertNotNull(nameof(operation1)), await operation2.AssertNotNull(nameof(operation2)), combiner);

        internal protected OperationResult()
        {
            IsSuccess = true;
        }

        internal protected OperationResult(IOperationError error)
        {
            IsSuccess = false;
            _error = error ?? throw new ArgumentNullException(nameof(error));
        }

        public bool IsSuccess { get; }

        public bool IsFailure
            => !IsSuccess;

        public IOperationError Error
            => !IsSuccess ? _error
                : throw new InvalidOperationException("Cannot retrieve error data for a successful operation");

        private readonly IOperationError _error;
    }
}
