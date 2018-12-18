using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnFailureExtensions
    {
        public static IOperationResult ContinueOnFailure(this IOperationResult prevOperationResult, Func<IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static IOperationResult ContinueOnFailure(this IOperationResult prevOperationResult, Func<object, IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static IOperationResult ContinueOnFailure<T>(this IOperationResult<T> prevOperationResult, Func<IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static IOperationResult ContinueOnFailure<T>(this IOperationResult<T> prevOperationResult, Func<object, IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static IOperationResult<T> ContinueOnFailure<T>(this IOperationResult<T> prevOperationResult, Func<IOperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    recoveryOperation);

        public static IOperationResult<T> ContinueOnFailure<T>(this IOperationResult<T> prevOperationResult, Func<object, IOperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<IOperationResult> ContinueOnFailureAsync(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<IOperationResult> ContinueOnFailureAsync(this IOperationResult prevOperationResult, AsyncFunc<object, IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<IOperationResult> ContinueOnFailureAsync<T>(this IOperationResult<T> prevOperationResult, AsyncFunc<IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<IOperationResult> ContinueOnFailureAsync<T>(this IOperationResult<T> prevOperationResult, AsyncFunc<object, IOperationResult> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this IOperationResult<T> prevOperationResult, AsyncFunc<IOperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    recoveryOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this IOperationResult<T> prevOperationResult, AsyncFunc<object, IOperationResult<T>> recoveryOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure,
                    x => recoveryOperation.AssertNotNull(nameof(recoveryOperation))
                        .Invoke(prevOperationResult.Error));

        public static async Task<IOperationResult> ContinueOnFailureAsync(this Task<IOperationResult> prevOperationResult, Func<IOperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync(this Task<IOperationResult> prevOperationResult, Func<object, IOperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync(this Task<IOperationResult> prevOperationResult, AsyncFunc<object, IOperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Func<IOperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Func<object, IOperationResult> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncFunc<IOperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<IOperationResult> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncFunc<object, IOperationResult> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Func<IOperationResult<T>> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Func<object, IOperationResult<T>> recoveryOperation)
            => (await prevOperationResult)
                .ContinueOnFailure(recoveryOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncFunc<IOperationResult<T>> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncFunc<object, IOperationResult<T>> recoveryOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureAsync(recoveryOperation);
    }
}
