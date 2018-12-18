using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultRequireOnSuccessExtensions
    {
        public static IOperationResult RequireOnSuccess(this IOperationResult currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(!condition,
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static IOperationResult RequireOnSuccess(this IOperationResult currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(!condition,
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, bool condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(!condition,
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static IOperationResult<T> RequireOnSuccess<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult> RequireOnSuccessAsync(this IOperationResult currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(!condition,
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult> RequireOnSuccessAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult> RequireOnSuccessAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult> RequireOnSuccessAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(!condition,
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(!condition,
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireOnSuccessAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Func<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireOnSuccessAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);
    }
}
