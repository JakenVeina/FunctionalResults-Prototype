using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoExtensions
    {
        public static OperationResult Do(this OperationResult primaryOperationResult, OperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult;

        public static OperationResult Do(this OperationResult primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static OperationResult Do(this OperationResult primaryOperationResult, Func<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static OperationResult Do<TSecondary>(this OperationResult primaryOperationResult, OperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult;

        public static OperationResult Do<TSecondary>(this OperationResult primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static OperationResult Do<TSecondary>(this OperationResult primaryOperationResult, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static OperationResult<TPrimary> Do<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, OperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult.AsFailure<TPrimary>();

        public static OperationResult<TPrimary> Do<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static OperationResult<TPrimary> Do<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static OperationResult<TPrimary> Do<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, OperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : secondaryOperationResult.AsFailure<TPrimary>();

        public static OperationResult<TPrimary> Do<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static OperationResult<TPrimary> Do<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.Do(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<OperationResult> DoAsync(this OperationResult primaryOperationResult, Task<OperationResult> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<OperationResult> DoAsync(this OperationResult primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<OperationResult> DoAsync(this OperationResult primaryOperationResult, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<OperationResult> DoAsync<TSecondary>(this OperationResult primaryOperationResult, Task<OperationResult<TSecondary>> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<OperationResult> DoAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<OperationResult> DoAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Task<OperationResult> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Task<OperationResult<TSecondary>> secondaryOperationResult)
            => primaryOperationResult.Do(await secondaryOperationResult);

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke(primaryOperationResult));

        public static Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, OperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult);

        public static Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, Func<OperationResult, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, OperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult as OperationResult);

        public static Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Func<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, OperationResult secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult.AsFailure<TPrimary>());

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, OperationResult<TSecondary> secondaryOperationResult)
            => secondaryOperationResult.AssertNotNull(nameof(secondaryOperationResult))
                .IsSuccess
                    ? primaryOperationResult
                    : Task.FromResult(secondaryOperationResult.AsFailure<TPrimary>());

        public static Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult.DoAsync(
                secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                    .Invoke());

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => (await primaryOperationResult)
                .Do(secondaryOperation);

        public static async Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, Task<OperationResult> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult> DoAsync(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Task<OperationResult<TSecondary>> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult> DoAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Task<OperationResult> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult<TPrimary>, OperationResult> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Task<OperationResult<TSecondary>> secondaryOperationResult)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperationResult);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);

        public static async Task<OperationResult<TPrimary>> DoAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult<TPrimary>, OperationResult<TSecondary>> secondaryOperation)
            => await (await primaryOperationResult)
                .DoAsync(secondaryOperation);
    }
}
