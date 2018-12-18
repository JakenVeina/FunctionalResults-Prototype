using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnFailureWhenExtensions
    {
        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    nextOperation);

        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, bool condition, Func<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, Predicate condition, Func<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static IOperationResult ContinueOnFailureWhen(this IOperationResult prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    nextOperation);

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static IOperationResult<T> ContinueOnFailureWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult> ContinueOnFailureWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Func<IOperationError, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Func<IOperationError, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult> ContinueOnFailureWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<IOperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);
    }
}
