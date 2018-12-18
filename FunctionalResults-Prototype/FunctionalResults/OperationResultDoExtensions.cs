using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoExtensions
    {
        public static IOperationResult Do(this IOperationResult primaryOperationResult, IOperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult;

        public static IOperationResult Do(this IOperationResult primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static IOperationResult Do(this IOperationResult primaryOperationResult, Func<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static IOperationResult Do<TSecondary>(this IOperationResult primaryOperationResult, IOperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult;

        public static IOperationResult Do<TSecondary>(this IOperationResult primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static IOperationResult Do<TSecondary>(this IOperationResult primaryOperationResult, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static IOperationResult<TPrimary> Do<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, IOperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult.AsFailure<TPrimary>();

        public static IOperationResult<TPrimary> Do<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static IOperationResult<TPrimary> Do<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static IOperationResult<TPrimary> Do<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, IOperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult.AsFailure<TPrimary>();

        public static IOperationResult<TPrimary> Do<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static IOperationResult<TPrimary> Do<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<IOperationResult> DoAsync(this IOperationResult primaryOperationResult, Task<IOperationResult> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<IOperationResult> DoAsync(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<IOperationResult> DoAsync(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<IOperationResult> DoAsync<TSecondary>(this IOperationResult primaryOperationResult, Task<IOperationResult<TSecondary>> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<IOperationResult> DoAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<IOperationResult> DoAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Task<IOperationResult> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Task<IOperationResult<TSecondary>> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, IOperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult);

        public static Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, IOperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult as IOperationResult);

        public static Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, IOperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult.AsFailure<TPrimary>());

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, IOperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult.AsFailure<TPrimary>());

        public static Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static async Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, Task<IOperationResult> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult> DoAsync(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Task<IOperationResult<TSecondary>> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult> DoAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Task<IOperationResult> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult<TPrimary>, IOperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Task<IOperationResult<TSecondary>> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<IOperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult<TPrimary>, IOperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);
    }
}
