using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnSuccessWhenExtensions
    {
        public static OperationResult DoOnSuccessWhen(this OperationResult primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static OperationResult DoOnSuccessWhen(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoOnSuccessWhen<TSecondary>(this OperationResult primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static OperationResult DoOnSuccessWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke());

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccessWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult> DoOnSuccessWhenAsync(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoOnSuccessWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<TPrimary, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<TPrimary, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoOnSuccessWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoOnSuccessWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<TPrimary> condition, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoOnSuccessWhenAsync(condition, secondaryOperation);
    }
}
