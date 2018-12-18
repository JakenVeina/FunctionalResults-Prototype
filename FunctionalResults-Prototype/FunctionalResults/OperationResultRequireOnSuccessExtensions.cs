using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultRequireOnSuccessExtensions
    {
        public static OperationResult RequireOnSuccess(this OperationResult currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(!condition,
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static OperationResult RequireOnSuccess(this OperationResult currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen<T>(!condition,
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, bool condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(!condition,
                    (T                     x) => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen<T>(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, Predicate condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    (T                     x) => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen((T x) => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static OperationResult<T> RequireOnSuccess<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult> RequireOnSuccessAsync(this OperationResult currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(!condition,
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult> RequireOnSuccessAsync(this OperationResult currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult> RequireOnSuccessAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult> RequireOnSuccessAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync<T>(!condition,
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(!condition,
                    async (T x) => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync<T>(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async (T x) => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync((T x) => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync<T>(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    (T                     x) => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync<T>(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async (T x) => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async (T x) => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Func<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async (T x) => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke()));

        public static Task<OperationResult<T>> RequireOnSuccessAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => currentOperationResult
                .DoOnSuccessWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(await errorBuilder.AssertNotNull(nameof(errorBuilder))
                        .Invoke(x)));

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireOnSuccessAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, Func<T, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .RequireOnSuccess(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Func<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireOnSuccessAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncFunc<T, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireOnSuccessAsync(condition, errorBuilder);
    }
}
