using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchWhenExtensions
    {
        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, bool condition, Action branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, bool condition, Action<IOperationResult> branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, Predicate condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, Predicate condition, Action<IOperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult BranchWhen(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, Action<IOperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Action branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, bool condition, Action<IOperationResult<T>> branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, Predicate condition, Action<IOperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static IOperationResult<T> BranchWhen<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, Action<IOperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncAction branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, bool condition, AsyncAction<IOperationResult> branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, Predicate condition, AsyncAction<IOperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, Action<IOperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate condition, AsyncAction<IOperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, Predicate<IOperationResult> condition, AsyncAction<IOperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, Action<IOperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this IOperationResult prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncAction<IOperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncAction branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, bool condition, AsyncAction<IOperationResult<T>> branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate condition, AsyncAction<IOperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, Action<IOperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncAction<IOperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncAction<IOperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Action<IOperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this IOperationResult<T> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncAction<IOperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, Action<IOperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, Action<IOperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, Action<IOperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, Action<IOperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, Action<IOperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, Action<IOperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, bool condition, AsyncAction<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate condition, AsyncAction<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, Action<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate condition, AsyncAction<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, Predicate<IOperationResult> condition, AsyncAction<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, Action<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult> BranchWhenAsync(this Task<IOperationResult> prevOperationResult, AsyncPredicate<IOperationResult> condition, AsyncAction<IOperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, bool condition, AsyncAction<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate condition, AsyncAction<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, Action<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncAction<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, Predicate<IOperationResult<T>> condition, AsyncAction<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, Action<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<IOperationResult<T>> BranchWhenAsync<T>(this Task<IOperationResult<T>> prevOperationResult, AsyncPredicate<IOperationResult<T>> condition, AsyncAction<IOperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);
    }
}
