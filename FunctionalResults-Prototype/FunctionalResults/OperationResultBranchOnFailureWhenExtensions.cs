using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnFailureWhenExtensions
    {
        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    branchAction);
            
        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static IOperationResult BranchOnFailureWhen(this IOperationResult currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    branchAction);

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static IOperationResult<T> BranchOnFailureWhen<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult> BranchOnFailureWhenAsync(this IOperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this IOperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchOnFailureWhenAsync(this Task<IOperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<IOperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);
    }
}
