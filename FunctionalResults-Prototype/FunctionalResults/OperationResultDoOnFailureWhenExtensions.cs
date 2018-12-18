using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnFailureWhenExtensions
    {
        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, bool condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, bool condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static OperationResult DoOnFailureWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke());

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailureWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnFailureWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnFailureWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnFailureWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationError> condition, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnFailureWhenAsync(condition, secondaryOperation);
    }
}
