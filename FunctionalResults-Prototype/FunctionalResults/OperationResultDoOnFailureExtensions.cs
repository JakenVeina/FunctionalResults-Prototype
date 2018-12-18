using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnFailureExtensions
    {
        public static OperationResult DoOnFailure(this OperationResult primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static OperationResult DoOnFailure(this OperationResult primaryOperationResult, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult DoOnFailure<TSecondary>(this OperationResult primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static OperationResult DoOnFailure<TSecondary>(this OperationResult primaryOperationResult, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailure<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailure<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static OperationResult<TPrimary> DoOnFailure<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static OperationResult<TPrimary> DoOnFailure<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync(this OperationResult primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync(this OperationResult primaryOperationResult, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this OperationResult primaryOperationResult, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this OperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync(this Task<OperationResult> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync(this Task<OperationResult> primaryOperationResult, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync(this Task<OperationResult> primaryOperationResult, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult> DoOnFailureAsync<TSecondary>(this Task<OperationResult> primaryOperationResult, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationError, OperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, Func<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<OperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<OperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationError, OperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));
    }
}
