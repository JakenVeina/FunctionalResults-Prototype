using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueExtensions
    {
        public static OperationResult Continue(this OperationResult prevOperationResult, OperationResult nextOperationResult)
            => nextOperationResult;

        public static OperationResult Continue(this OperationResult prevOperationResult, Func<OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static OperationResult Continue(this OperationResult prevOperationResult, Func<OperationResult, OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static OperationResult<TNext> Continue<TNext>(this OperationResult prevOperationResult, OperationResult<TNext> nextOperationResult)
            => nextOperationResult;

        public static OperationResult<TNext> Continue<TNext>(this OperationResult prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static OperationResult<TNext> Continue<TNext>(this OperationResult prevOperationResult, Func<OperationResult, OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static OperationResult Continue<TPrev>(this OperationResult<TPrev> prevOperationResult, OperationResult nextOperationResult)
            => nextOperationResult;

        public static OperationResult Continue<TPrev>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static OperationResult Continue<TPrev>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult<TPrev>, OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static OperationResult<TNext> Continue<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, OperationResult<TNext> nextOperationResult)
            => nextOperationResult;

        public static OperationResult<TNext> Continue<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static OperationResult<TNext> Continue<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult<TPrev>, OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<OperationResult> ContinueAsync(this OperationResult prevOperationResult, Task<OperationResult> nextOperationResult)
            => nextOperationResult;

        public static Task<OperationResult> ContinueAsync(this OperationResult prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<OperationResult> ContinueAsync(this OperationResult prevOperationResult, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<OperationResult<TNext>> ContinueAsync<TNext>(this OperationResult prevOperationResult, Task<OperationResult<TNext>> nextOperationResult)
            => nextOperationResult;

        public static Task<OperationResult<TNext>> ContinueAsync<TNext>(this OperationResult prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<OperationResult<TNext>> ContinueAsync<TNext>(this OperationResult prevOperationResult, AsyncFunc<OperationResult, OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<OperationResult> ContinueAsync<TPrev>(this OperationResult<TPrev> prevOperationResult, Task<OperationResult> nextOperationResult)
            => nextOperationResult;

        public static Task<OperationResult> ContinueAsync<TPrev>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<OperationResult> ContinueAsync<TPrev>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult<TPrev>, OperationResult> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, Task<OperationResult<TNext>> nextOperationResult)
            => nextOperationResult;

        public static Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke();

        public static Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult<TPrev>, OperationResult<TNext>> nextOperation)
            => nextOperation.AssertNotNull(nameof(nextOperation))
                .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)));

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, OperationResult nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, Func<OperationResult, OperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, OperationResult<TNext> nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, Func<OperationResult, OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, OperationResult nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult<TPrev>, OperationResult> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, OperationResult<TNext> nextOperationResult)
            => (await prevOperationResult)
                .Continue(nextOperationResult);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult<TPrev>, OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
                .Continue(nextOperation);

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, Task<OperationResult> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult> ContinueAsync(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, Task<OperationResult<TNext>> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TNext>(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult, OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, Task<OperationResult> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult> ContinueAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult<TPrev>, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, Task<OperationResult<TNext>> nextOperationResult)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperationResult);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult<TPrev>, OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
                .ContinueAsync(nextOperation);
    }
}
