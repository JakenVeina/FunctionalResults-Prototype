using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnSuccessExtensions
    {
        public static IOperationResult DoOnSuccess(this IOperationResult primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static IOperationResult DoOnSuccess<TSecondary>(this IOperationResult primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccess<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccess<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static IOperationResult<TPrimary> DoOnSuccess<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnSuccess<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult> DoOnSuccessAsync(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult> DoOnSuccessAsync(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessAsync(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnSuccessAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<TPrimary, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<TPrimary, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));
    }
}
