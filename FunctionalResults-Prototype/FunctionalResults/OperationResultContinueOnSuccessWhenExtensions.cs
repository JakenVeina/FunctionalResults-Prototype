using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnSuccessWhenExtensions
    {
        public static OperationResult ContinueOnSuccessWhen(this OperationResult prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    nextOperation);

        public static OperationResult ContinueOnSuccessWhen(this OperationResult prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    nextOperation);

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, Predicate<T> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static OperationResult<T> ContinueOnSuccessWhen<T>(this OperationResult<T> prevOperationResult, Predicate<T> condition, Func<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult> ContinueOnSuccessWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    nextOperation);

        public static Task<OperationResult> ContinueOnSuccessWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueOnSuccessWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueOnSuccessWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<T> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<T> condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<T> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<T> condition, Func<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnSuccessWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<T, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<T, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<T> condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<T> condition, Func<T, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<T> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<T> condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, Func<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);
    }
}
