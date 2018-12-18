using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnFailureWhenExtensions
    {
        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, bool condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, bool condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static IOperationResult DoOnFailureWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke());

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);
    }
}
