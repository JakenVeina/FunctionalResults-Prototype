using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultDoOnFailureExtensions
    {
        public static IOperationResult DoOnFailure(this IOperationResult primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static IOperationResult DoOnFailure(this IOperationResult primaryOperationResult, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult DoOnFailure<TSecondary>(this IOperationResult primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static IOperationResult DoOnFailure<TSecondary>(this IOperationResult primaryOperationResult, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailure<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailure<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static IOperationResult<TPrimary> DoOnFailure<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    secondaryOperation);

        public static IOperationResult<TPrimary> DoOnFailure<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhen(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync(this IOperationResult primaryOperationResult, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this IOperationResult primaryOperationResult, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this IOperationResult<TPrimary> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync(this Task<IOperationResult> primaryOperationResult, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult> DoOnFailureAsync<TSecondary>(this Task<IOperationResult> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, Func<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    secondaryOperation);

        public static Task<IOperationResult<TPrimary>> DoOnFailureAsync<TPrimary, TSecondary>(this Task<IOperationResult<TPrimary>> primaryOperationResult, AsyncFunc<IOperationError, IOperationResult<TSecondary>> secondaryOperation)
            => primaryOperationResult
                .DoWhenAsync(x => x.IsFailure,
                    x => secondaryOperation.AssertNotNull(nameof(secondaryOperation))
                        .Invoke(x.Error));
    }
}
