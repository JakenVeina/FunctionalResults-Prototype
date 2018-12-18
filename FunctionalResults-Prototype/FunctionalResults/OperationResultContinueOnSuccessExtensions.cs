using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnSuccessExtensions
    {
        public static IOperationResult ContinueOnSuccess(this IOperationResult prevOperationResult, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    nextOperation);

        public static IOperationResult ContinueOnSuccess<TPrev>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    nextOperation);

        public static IOperationResult ContinueOnSuccess<TPrev>(this IOperationResult<TPrev> prevOperationResult, Func<TPrev, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static IOperationResult<TNext> ContinueOnSuccess<TNext>(this IOperationResult prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult.AsFailure<TNext>();

        public static IOperationResult<TNext> ContinueOnSuccess<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult.AsFailure<TNext>();

        public static IOperationResult<TNext> ContinueOnSuccess<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, Func<TPrev, IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value))
                : prevOperationResult.AsFailure<TNext>();

        public static Task<IOperationResult> ContinueOnSuccessAsync(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    nextOperation);

        public static Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    nextOperation);

        public static Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<TPrev, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this IOperationResult prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this IOperationResult<TPrev> prevOperationResult, AsyncFunc<TPrev, IOperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value))
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static async Task<IOperationResult> ContinueOnSuccessAsync(this Task<IOperationResult> prevOperationResult, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<TPrev, IOperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this Task<IOperationResult> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, Func<TPrev, IOperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessAsync(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessAsync<TPrev>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<TPrev, IOperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this Task<IOperationResult> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<IOperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<IOperationResult<TPrev>> prevOperationResult, AsyncFunc<TPrev, IOperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);
    }
}
