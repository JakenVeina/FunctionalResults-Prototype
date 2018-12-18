using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnSuccessWhenExtensions
    {
        public static IOperationResult ContinueOnSuccessWhen(this IOperationResult prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    nextOperation);

        public static IOperationResult ContinueOnSuccessWhen(this IOperationResult prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    nextOperation);

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<T> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static IOperationResult<T> ContinueOnSuccessWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<T> condition, Func<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult> ContinueOnSuccessWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    nextOperation);

        public static Task<IOperationResult> ContinueOnSuccessWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnSuccessWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnSuccessWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<T> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<T> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<T> condition, Func<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(prevOperationResult.Value),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(prevOperationResult.Value));

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnSuccessWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<T, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<T, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<T> condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<T> condition, Func<T, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnSuccessWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<T> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, Func<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnSuccessWhenAsync(condition, nextOperation);
    }
}
