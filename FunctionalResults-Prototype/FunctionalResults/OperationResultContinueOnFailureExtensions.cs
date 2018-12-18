using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnFailureExtensions
    {
        public static OperationResult ContinueOnFailure(this OperationResult prevOperationResult, Func<OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static OperationResult ContinueOnFailure(this OperationResult prevOperationResult, Func<object, OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static OperationResult ContinueOnFailure<T>(this OperationResult<T> prevOperationResult, Func<OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static OperationResult ContinueOnFailure<T>(this OperationResult<T> prevOperationResult, Func<object, OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static OperationResult<T> ContinueOnFailure<T>(this OperationResult<T> prevOperationResult, Func<OperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static OperationResult<T> ContinueOnFailure<T>(this OperationResult<T> prevOperationResult, Func<object, OperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<OperationResult> ContinueOnFailureAsync(this OperationResult prevOperationResult, AsyncFunc<OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<OperationResult> ContinueOnFailureAsync(this OperationResult prevOperationResult, AsyncFunc<object, OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<OperationResult> ContinueOnFailureAsync<T>(this OperationResult<T> prevOperationResult, AsyncFunc<OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<OperationResult> ContinueOnFailureAsync<T>(this OperationResult<T> prevOperationResult, AsyncFunc<object, OperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<OperationResult<T>> ContinueOnFailureAsync<T>(this OperationResult<T> prevOperationResult, AsyncFunc<OperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<OperationResult<T>> ContinueOnFailureAsync<T>(this OperationResult<T> prevOperationResult, AsyncFunc<object, OperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static async Task<OperationResult> ContinueOnFailureAsync(this Task<OperationResult> prevOperationResult, Func<OperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync(this Task<OperationResult> prevOperationResult, Func<object, OperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync(this Task<OperationResult> prevOperationResult, AsyncFunc<object, OperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, Func<OperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, Func<object, OperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncFunc<OperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<OperationResult> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncFunc<object, OperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, Func<OperationResult<T>> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, Func<object, OperationResult<T>> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncFunc<OperationResult<T>> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncFunc<object, OperationResult<T>> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);
    }
}
