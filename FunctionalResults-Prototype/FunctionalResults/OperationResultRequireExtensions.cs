using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultRequireExtensions
    {
        public static OperationResult Require(this OperationResult currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult Require(this OperationResult currentOperationResult, bool condition, Func<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static OperationResult Require(this OperationResult currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult Require(this OperationResult currentOperationResult, Predicate condition, Func<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static OperationResult Require(this OperationResult currentOperationResult, Predicate<OperationResult> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult Require(this OperationResult currentOperationResult, Predicate<OperationResult> condition, Func<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, bool condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(!condition,
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, Predicate condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, Predicate<OperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static OperationResult<T> Require<T>(this OperationResult<T> currentOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhen(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, bool condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, Predicate condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, Predicate<OperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Func<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    (FunctionalResults.OperationResult                     x) => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke((FunctionalResults.OperationResult)x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate<OperationResult> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async (FunctionalResults.OperationResult x) => !await condition.AssertNotNull(nameof(condition))
                        .Invoke((FunctionalResults.OperationResult)x),
                    () => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async (FunctionalResults.OperationResult x) => !await condition.AssertNotNull(nameof(condition))
                        .Invoke((FunctionalResults.OperationResult)x),
                    (FunctionalResults.OperationResult                     x) => (FunctionalResults.OperationResult)FunctionalResults.OperationResult.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke((FunctionalResults.OperationResult)x)));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult> RequireAsync(this OperationResult currentOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(!condition,
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(() => !condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(x => !condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async () => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    () => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    x => OperationResult<T>.FromError(
                        errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async () => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke()));

        public static Task<OperationResult<T>> RequireAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => currentOperationResult
                .DoWhenAsync(async x => !await condition.AssertNotNull(nameof(condition))
                        .Invoke(x),
                    async x => OperationResult<T>.FromError(
                        await errorBuilder.AssertNotNull(nameof(errorBuilder))
                            .Invoke(x)));

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, bool condition, Func<OperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Func<OperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate<OperationResult> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate<OperationResult> condition, Func<OperationResult, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate<OperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, Predicate<OperationResult> condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Func<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<OperationResult> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<OperationResult> condition, Func<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult> RequireAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<OperationResult> condition, AsyncFunc<OperationResult, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<OperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<OperationResult<T>> condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => (await currentOperationResult)
                .Require(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, Func<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);

        public static async Task<OperationResult<T>> RequireAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncFunc<OperationResult<T>, IOperationError> errorBuilder)
            => await (await currentOperationResult)
                .RequireAsync(condition, errorBuilder);
    }
}
