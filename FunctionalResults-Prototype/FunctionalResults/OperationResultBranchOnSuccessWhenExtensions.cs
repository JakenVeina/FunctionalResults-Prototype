using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnSuccessWhenExtensions
    {
        public static OperationResult BranchOnSuccessWhen(this OperationResult currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    branchAction);

        public static OperationResult BranchOnSuccessWhen(this OperationResult currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    branchAction);

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, bool condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, Predicate condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static OperationResult<T> BranchOnSuccessWhen<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult> BranchOnSuccessWhenAsync(this OperationResult currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    branchAction);

        public static Task<OperationResult> BranchOnSuccessWhenAsync(this OperationResult currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult> BranchOnSuccessWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult> BranchOnSuccessWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate<T> condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnSuccessWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Action<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Action<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);
    }
}
