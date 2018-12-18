using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnSuccessExtensions
    {
        public static OperationResult ContinueOnSuccess(this OperationResult prevOperationResult, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    nextOperation);

        public static OperationResult ContinueOnSuccess<TPrev>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    nextOperation);

        public static OperationResult ContinueOnSuccess<TPrev>(this OperationResult<TPrev> prevOperationResult, Func<TPrev, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static OperationResult<TNext> ContinueOnSuccess<TNext>(this OperationResult prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult.AsFailure<TNext>();

        public static OperationResult<TNext> ContinueOnSuccess<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult.AsFailure<TNext>();

        public static OperationResult<TNext> ContinueOnSuccess<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, Func<TPrev, OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .Continue(x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value))
                : prevOperationResult.AsFailure<TNext>();

        public static Task<OperationResult> ContinueOnSuccessAsync(this OperationResult prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    nextOperation);

        public static Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    nextOperation);

        public static Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<TPrev, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this OperationResult prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this OperationResult<TPrev> prevOperationResult, AsyncFunc<TPrev, OperationResult<TNext>> nextOperation)
            => prevOperationResult.AssertNotNull(nameof(prevOperationResult))
                    .IsSuccess
                ? prevOperationResult
                    .ContinueAsync(x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value))
                : Task.FromResult(prevOperationResult.AsFailure<TNext>());

        public static async Task<OperationResult> ContinueOnSuccessAsync(this Task<OperationResult> prevOperationResult, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, Func<TPrev, OperationResult> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this Task<OperationResult> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, Func<OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, Func<TPrev, OperationResult<TNext>> nextOperation)
            => (await prevOperationResult)
            .ContinueOnSuccess(nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessAsync(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessAsync<TPrev>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<TPrev, OperationResult> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TNext>(this Task<OperationResult> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);

        public static async Task<OperationResult<TNext>> ContinueOnSuccessAsync<TPrev, TNext>(this Task<OperationResult<TPrev>> prevOperationResult, AsyncFunc<TPrev, OperationResult<TNext>> nextOperation)
            => await (await prevOperationResult)
            .ContinueOnSuccessAsync(nextOperation);
    }
}
