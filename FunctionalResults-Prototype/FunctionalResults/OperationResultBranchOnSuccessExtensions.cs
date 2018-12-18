using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnSuccessExtensions
    {
        public static IOperationResult BranchOnSuccess(this IOperationResult prevOperationResult, Action branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    branchAction);

        public static IOperationResult<T> BranchOnSuccess<T>(this IOperationResult<T> prevOperationResult, Action branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    branchAction);

        public static IOperationResult<T> BranchOnSuccess<T>(this IOperationResult<T> prevOperationResult, Action<T> branchAction)
            => prevOperationResult
                .BranchWhen(x => x.IsSuccess,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult> BranchOnSuccessAsync(this IOperationResult prevOperationResult, AsyncAction branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessAsync<T>(this IOperationResult<T> prevOperationResult, AsyncAction branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessAsync<T>(this IOperationResult<T> prevOperationResult, AsyncAction<T> branchAction)
            => prevOperationResult
                .BranchWhenAsync(x => x.IsSuccess,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static async Task<IOperationResult> BranchOnSuccess(this Task<IOperationResult> prevOperationResult, Action branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccess<T>(this Task<IOperationResult<T>> prevOperationResult, Action branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccess<T>(this Task<IOperationResult<T>> prevOperationResult, Action<T> branchAction)
            => (await prevOperationResult)
                .BranchOnSuccess(branchAction);

        public static async Task<IOperationResult> BranchOnSuccessAsync(this Task<IOperationResult> prevOperationResult, AsyncAction branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncAction branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncAction<T> branchAction)
            => await (await prevOperationResult)
                .BranchOnSuccessAsync(branchAction);
    }
}
