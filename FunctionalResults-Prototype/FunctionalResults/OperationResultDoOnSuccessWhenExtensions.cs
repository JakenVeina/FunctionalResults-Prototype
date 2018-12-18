using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnSuccessWhenExtensions
    {
        public static IOperationResult DoOnSuccessWhen(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static IOperationResult DoOnSuccessWhen(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoOnSuccessWhen<TSecondary>(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static IOperationResult DoOnSuccessWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke());

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult> DoOnSuccessWhenAsync(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);
    }
}
