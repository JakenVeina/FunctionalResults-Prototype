using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchExtensions
    {
        public static IOperationResult Branch(this IOperationResult currentOperationResult, Action branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static IOperationResult Branch(this IOperationResult currentOperationResult, Action<IOperationResult> branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static IOperationResult<T> Branch<T>(this IOperationResult<T> currentOperationResult, Action branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static IOperationResult<T> Branch<T>(this IOperationResult<T> currentOperationResult, Action<IOperationResult<T>> branchAction)
        {
            branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<IOperationResult> BranchAsync(this IOperationResult currentOperationResult, AsyncAction branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static async Task<IOperationResult> BranchAsync(this IOperationResult currentOperationResult, AsyncAction<IOperationResult> branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<IOperationResult<T>> BranchAsync<T>(this IOperationResult<T> currentOperationResult, AsyncAction branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke();

            return currentOperationResult;
        }

        public static async Task<IOperationResult<T>> BranchAsync<T>(this IOperationResult<T> currentOperationResult, AsyncAction<IOperationResult<T>> branchAction)
        {
            await branchAction.AssertNotNull(nameof(branchAction))
                .Invoke(currentOperationResult.AssertNotNull(nameof(currentOperationResult)));

            return currentOperationResult;
        }

        public static async Task<IOperationResult> BranchAsync(this Task<IOperationResult> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<IOperationResult> BranchAsync(this Task<IOperationResult> currentOperationResult, Action<IOperationResult> branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<IOperationResult> BranchAsync(this Task<IOperationResult> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<IOperationResult> BranchAsync(this Task<IOperationResult> currentOperationResult, AsyncAction<IOperationResult> branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Action branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<IOperationResult<T>> BranchAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Action<IOperationResult<T>> branchAction)
            => (await currentOperationResult)
                .Branch(branchAction);

        public static async Task<IOperationResult<T>> BranchAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncAction<IOperationResult<T>> branchAction)
            => await (await currentOperationResult)
                .BranchAsync(branchAction);
    }
}
