using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueWhenExtensions
    {
        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, bool condition, Func<OperationResult, OperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, Predicate condition, Func<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, Predicate<OperationResult> condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static OperationResult ContinueWhen(this OperationResult prevOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static OperationResult<T> ContinueWhen<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Func<OperationResult, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Func<OperationResult, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);
    }
}
