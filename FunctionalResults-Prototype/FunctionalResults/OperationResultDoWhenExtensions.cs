using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoWhenExtensions
    {
        public static OperationResult DoWhen(this OperationResult primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static OperationResult DoWhen(this OperationResult primaryOperationResult, bool condition, Func<OperationResult, OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static OperationResult DoWhen(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoWhen(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoWhen(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult DoWhen(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, bool condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult DoWhen<TSecondary>(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static OperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, bool condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult> DoWhenAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Predicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<OperationResult<TPrimary>> condition, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);
    }
}
