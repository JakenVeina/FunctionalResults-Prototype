using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueWhenExtensions
    {
        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, bool condition, Func<IOperationResult, IOperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, Predicate condition, Func<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static IOperationResult ContinueWhen(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .Continue(nextOperation)
                : prevOperationResult;

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static IOperationResult<T> ContinueWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => condition
                ? prevOperationResult
                    .ContinueAsync(nextOperation)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await prevOperationResult
                .ContinueWhenAsync(
                    await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult))),
                    nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Func<IOperationResult, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Func<IOperationResult, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueWhenAsync(condition, nextOperation);
    }
}
