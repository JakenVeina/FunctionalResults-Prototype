using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnFailureExtensions
    {
        public static IOperationResult BranchOnFailure(this IOperationResult currentOperationResult, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    branchAction);

        public static IOperationResult BranchOnFailure(this IOperationResult currentOperationResult, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult<T> BranchOnFailure<T>(this IOperationResult<T> currentOperationResult, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    branchAction);

        public static IOperationResult<T> BranchOnFailure<T>(this IOperationResult<T> currentOperationResult, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureAsync(this IOperationResult currentOperationResult, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureAsync(this IOperationResult currentOperationResult, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureAsync<T>(this IOperationResult<T> currentOperationResult, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureAsync<T>(this IOperationResult<T> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static async Task<IOperationResult> BranchOnFailureAsync(this Task<IOperationResult> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<IOperationResult> BranchOnFailureAsync(this Task<IOperationResult> currentOperationResult, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<IOperationResult> BranchOnFailureAsync(this Task<IOperationResult> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<IOperationResult> BranchOnFailureAsync(this Task<IOperationResult> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);
    }
}
