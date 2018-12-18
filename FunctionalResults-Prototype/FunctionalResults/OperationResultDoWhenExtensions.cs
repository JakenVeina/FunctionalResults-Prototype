using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoWhenExtensions
    {
        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult DoWhen(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, bool condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult DoWhen<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation)
                : primaryOperationResult;

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.Do(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : primaryOperationResult;

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoWhen<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(
                    condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation)
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => condition
                ? primaryOperationResult.DoAsync(
                    secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))))
                : Task.FromResult(primaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await primaryOperationResult
                .DoWhenAsync(await condition.AssertNotNull(nameof(condition))
                        .Invoke(primaryOperationResult.AssertNotNull(nameof(primaryOperationResult))),
                    secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult> DoWhenAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, bool condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .DoWhen(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Predicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoWhenAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncPredicate<IOperationResult<TPrimary>> condition, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoWhenAsync(condition, secondaryOperation);
    }
}
