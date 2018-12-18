using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnSuccessExtensions
    {
        public static OperationResult BranchOnSuccess(this OperationResult prevOperationResult, Action branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    branchAction);

        public static OperationResult<T> BranchOnSuccess<T>(this OperationResult<T> prevOperationResult, Action branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    branchAction);

        public static OperationResult<T> BranchOnSuccess<T>(this OperationResult<T> prevOperationResult, Action<T> branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult> BranchOnSuccessAsync(this OperationResult prevOperationResult, AsyncAction branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessAsync<T>(this OperationResult<T> prevOperationResult, AsyncAction branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessAsync<T>(this OperationResult<T> prevOperationResult, AsyncAction<T> branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static async Task<OperationResult> BranchOnSuccess(this Task<OperationResult> prevOperationResult, Action branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccess<T>(this Task<OperationResult<T>> prevOperationResult, Action branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccess<T>(this Task<OperationResult<T>> prevOperationResult, Action<T> branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<OperationResult> BranchOnSuccessAsync(this Task<OperationResult> prevOperationResult, AsyncAction branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncAction branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncAction<T> branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);
    }
}
