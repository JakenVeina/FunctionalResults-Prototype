using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchExtensions
    {
        public static OperationResult Branch(this OperationResult currentOperationResult, Action branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static OperationResult Branch(this OperationResult currentOperationResult, Action<OperationResult> branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static OperationResult<T> Branch<T>(this OperationResult<T> currentOperationResult, Action branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static OperationResult<T> Branch<T>(this OperationResult<T> currentOperationResult, Action<OperationResult<T>> branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<OperationResult> BranchAsync(this OperationResult currentOperationResult, AsyncAction branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static async Task<OperationResult> BranchAsync(this OperationResult currentOperationResult, AsyncAction<OperationResult> branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<OperationResult<T>> BranchAsync<T>(this OperationResult<T> currentOperationResult, AsyncAction branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static async Task<OperationResult<T>> BranchAsync<T>(this OperationResult<T> currentOperationResult, AsyncAction<OperationResult<T>> branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<OperationResult> BranchAsync(this Task<OperationResult> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<OperationResult> BranchAsync(this Task<OperationResult> currentOperationResult, Action<OperationResult> branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<OperationResult> BranchAsync(this Task<OperationResult> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<OperationResult> BranchAsync(this Task<OperationResult> currentOperationResult, AsyncAction<OperationResult> branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<OperationResult<T>> BranchAsync<T>(this Task<OperationResult<T>> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<OperationResult<T>> BranchAsync<T>(this Task<OperationResult<T>> currentOperationResult, Action<OperationResult<T>> branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<OperationResult<T>> BranchAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<OperationResult<T>> BranchAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncAction<OperationResult<T>> branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);
    }
}
