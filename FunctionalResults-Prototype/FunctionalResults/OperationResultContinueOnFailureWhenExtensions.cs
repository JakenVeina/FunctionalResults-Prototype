using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultContinueOnFailureWhenExtensions
    {
        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    nextOperation);

        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, bool condition, Func<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, Predicate condition, Func<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, Predicate<IOperationError> condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static OperationResult ContinueOnFailureWhen(this OperationResult prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    nextOperation);

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, Predicate<IOperationError> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static OperationResult<T> ContinueOnFailureWhen<T>(this OperationResult<T> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult> ContinueOnFailureWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition,
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    nextOperation);

        public static Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => prevOperationResult
                .ContinueWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => nextOperation.AssertNotNull(nameof(nextOperation))
                        .Invoke(x.Error));

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Func<IOperationError, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Func<IOperationError, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<IOperationError> condition, Func<OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Func<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult> ContinueOnFailureWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, Func<OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => (await prevOperationResult)
                .ContinueOnFailureWhen(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);

        public static async Task<OperationResult<T>> ContinueOnFailureWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<T>> nextOperation)
            => await (await prevOperationResult)
                .ContinueOnFailureWhenAsync(condition, nextOperation);
    }
}
