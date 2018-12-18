using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnSuccessExtensions
    {
        public static OperationResult DoOnSuccess(this OperationResult primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static OperationResult DoOnSuccess<TSecondary>(this OperationResult primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccess<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccess<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static OperationResult<TPrimary> DoOnSuccess<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnSuccess<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult> DoOnSuccessAsync(this OperationResult primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult> DoOnSuccessAsync(this Task<OperationResult> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessAsync(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult> DoOnSuccessAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<TPrimary, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnSuccessAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<TPrimary, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsSuccess,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Value));
    }
}
