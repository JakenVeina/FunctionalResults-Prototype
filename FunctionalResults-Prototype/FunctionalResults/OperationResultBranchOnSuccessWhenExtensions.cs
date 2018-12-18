using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnSuccessWhenExtensions
    {
        public static IOperationResult BranchOnSuccessWhen(this IOperationResult currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    branchAction);

        public static IOperationResult BranchOnSuccessWhen(this IOperationResult currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    branchAction);

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, bool condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static IOperationResult<T> BranchOnSuccessWhen<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult> BranchOnSuccessWhenAsync(this IOperationResult currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    branchAction);

        public static Task<IOperationResult> BranchOnSuccessWhenAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult> BranchOnSuccessWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult> BranchOnSuccessWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<T> condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsSuccess && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, Action<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<T> condition, AsyncAction<T> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsSuccess && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Value),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Value));

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnSuccessWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, Action<T> branchAction)
            => (await currentOperationResult)
                .BranchOnSuccessWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<T> condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Action<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, Action<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnSuccessWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<T> condition, AsyncAction<T> branchAction)
            => await (await currentOperationResult)
                .BranchOnSuccessWhenAsync(condition, branchAction);
    }
}
