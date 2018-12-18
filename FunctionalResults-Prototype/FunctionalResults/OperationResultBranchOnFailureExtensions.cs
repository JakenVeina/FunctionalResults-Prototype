using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnFailureExtensions
    {
        public static OperationResult BranchOnFailure(this OperationResult currentOperationResult, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    branchAction);

        public static OperationResult BranchOnFailure(this OperationResult currentOperationResult, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult<T> BranchOnFailure<T>(this OperationResult<T> currentOperationResult, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    branchAction);

        public static OperationResult<T> BranchOnFailure<T>(this OperationResult<T> currentOperationResult, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureAsync(this OperationResult currentOperationResult, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    branchAction);

        public static Task<OperationResult> BranchOnFailureAsync(this OperationResult currentOperationResult, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureAsync<T>(this OperationResult<T> currentOperationResult, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureAsync<T>(this OperationResult<T> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static async Task<OperationResult> BranchOnFailureAsync(this Task<OperationResult> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<OperationResult> BranchOnFailureAsync(this Task<OperationResult> currentOperationResult, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<OperationResult> BranchOnFailureAsync(this Task<OperationResult> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<OperationResult> BranchOnFailureAsync(this Task<OperationResult> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureAsync<T>(this Task<OperationResult<T>> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureAsync<T>(this Task<OperationResult<T>> currentOperationResult, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailure(branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureAsync(branchAction);
    }
}
