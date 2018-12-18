using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueExtensions
    {
        public static IOperationResult Continue(this IOperationResult prevOperationResult, IOperationResult nextOperationResult)
            => nextOperationResult;

        public static IOperationResult Continue(this IOperationResult prevOperationResult, Func<IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static IOperationResult Continue(this IOperationResult prevOperationResult, Func<IOperationResult, IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static IOperationResult<TNext> Continue<TNext>(this IOperationResult prevOperationResult, IOperationResult<TNext> nextOperationResult)
            => nextOperationResult;

        public static IOperationResult<TNext> Continue<TNext>(this IOperationResult prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static IOperationResult<TNext> Continue<TNext>(this IOperationResult prevOperationResult, Func<IOperationResult, IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static IOperationResult Continue<TPrev>(this IOperationResult<TPrev> prevOperationResult, IOperationResult nextOperationResult)
            => nextOperationResult;

        public static IOperationResult Continue<TPrev>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static IOperationResult Continue<TPrev>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult<TPrev>, IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static IOperationResult<TNext> Continue<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, IOperationResult<TNext> nextOperationResult)
            => nextOperationResult;

        public static IOperationResult<TNext> Continue<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static IOperationResult<TNext> Continue<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult<TPrev>, IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<IOperationResult> ContinueAsync(this IOperationResult prevOperationResult, Task<IOperationResult> nextOperationResult)
            => nextOperationResult;

        public static Task<IOperationResult> ContinueAsync(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<IOperationResult> ContinueAsync(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<IOperationResult<TNext>> ContinueAsync<TNext>(this IOperationResult prevOperationResult, Task<IOperationResult<TNext>> nextOperationResult)
            => nextOperationResult;

        public static Task<IOperationResult<TNext>> ContinueAsync<TNext>(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<IOperationResult<TNext>> ContinueAsync<TNext>(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult, IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<IOperationResult> ContinueAsync<TPrev>(this IOperationResult<TPrev> prevOperationResult, Task<IOperationResult> nextOperationResult)
            => nextOperationResult;

        public static Task<IOperationResult> ContinueAsync<TPrev>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<IOperationResult> ContinueAsync<TPrev>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult<TPrev>, IOperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, Task<IOperationResult<TNext>> nextOperationResult)
            => nextOperationResult;

        public static Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult<TPrev>, IOperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, IOperationResult nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, Func<IOperationResult, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, IOperationResult<TNext> nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, Func<IOperationResult, IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, IOperationResult nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult<TPrev>, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, IOperationResult<TNext> nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult<TPrev>, IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, Task<IOperationResult> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult> ContinueAsync(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, Task<IOperationResult<TNext>> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TNext>(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult, IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, Task<IOperationResult> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult> ContinueAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult<TPrev>, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, Task<IOperationResult<TNext>> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult<TPrev>, IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);
    }
}
