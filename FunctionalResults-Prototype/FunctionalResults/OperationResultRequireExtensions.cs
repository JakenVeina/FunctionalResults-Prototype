using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultRequireExtensions
    {
        public static IOperationResult Require(this IOperationResult currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult Require(this IOperationResult currentOperationResult, bool condition, Func<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static IOperationResult Require(this IOperationResult currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult Require(this IOperationResult currentOperationResult, Predicate condition, Func<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static IOperationResult Require(this IOperationResult currentOperationResult, Predicate<IOperationResult> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult Require(this IOperationResult currentOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, bool condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static IOperationResult<T> Require<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult> RequireAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<IOperationResult<T>> RequireAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, bool condition, Func<IOperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Func<IOperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationResult> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationResult> condition, Func<IOperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Func<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationResult> condition, Func<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult> RequireAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationResult> condition, AsyncFunc<IOperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, Func<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<IOperationResult<T>> RequireAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncFunc<IOperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);
    }
}
