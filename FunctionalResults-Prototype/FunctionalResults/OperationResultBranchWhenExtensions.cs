using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchWhenExtensions
    {
        public static OperationResult BranchWhen(this OperationResult prevOperationResult, bool condition, Action branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult BranchWhen(this OperationResult prevOperationResult, bool condition, Action<OperationResult> branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult BranchWhen(this OperationResult prevOperationResult, Predicate condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult BranchWhen(this OperationResult prevOperationResult, Predicate condition, Action<OperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult BranchWhen(this OperationResult prevOperationResult, Predicate<OperationResult> condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult BranchWhen(this OperationResult prevOperationResult, Predicate<OperationResult> condition, Action<OperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Action branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, bool condition, Action<OperationResult<T>> branchAction)
            => condition
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, Predicate condition, Action<OperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, Action branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static OperationResult<T> BranchWhen<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, Action<OperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncAction branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, bool condition, AsyncAction<OperationResult> branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, Predicate condition, AsyncAction<OperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, Action<OperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate condition, AsyncAction<OperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, Predicate<OperationResult> condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, Predicate<OperationResult> condition, AsyncAction<OperationResult> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, Action<OperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this OperationResult prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncAction<OperationResult> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncAction branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, bool condition, AsyncAction<OperationResult<T>> branchAction)
            => condition
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate condition, AsyncAction<OperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, Action<OperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate condition, AsyncAction<OperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke()
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncAction branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncAction<OperationResult<T>> branchAction)
            => condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .BranchAsync(branchAction)
                : Task.FromResult(prevOperationResult);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Action branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Action<OperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? prevOperationResult
                    .Branch(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncAction branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this OperationResult<T> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncAction<OperationResult<T>> branchAction)
            => await condition.AssertNotNull(nameof(condition))
                    .Invoke(prevOperationResult.AssertNotNull(nameof(prevOperationResult)))
                ? await prevOperationResult
                    .BranchAsync(branchAction)
                : prevOperationResult;

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, Action<OperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, Action<OperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, Action<OperationResult> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, Action<OperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, Action<OperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, Action branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, Action<OperationResult<T>> branchAction)
            => (await prevOperationResult).BranchWhen(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, bool condition, AsyncAction<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate condition, AsyncAction<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, Action<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate condition, AsyncAction<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, Predicate<OperationResult> condition, AsyncAction<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, Action<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchWhenAsync(this Task<OperationResult> prevOperationResult, AsyncPredicate<OperationResult> condition, AsyncAction<OperationResult> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, bool condition, AsyncAction<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate condition, AsyncAction<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, Action<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate condition, AsyncAction<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, Predicate<OperationResult<T>> condition, AsyncAction<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Action branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, Action<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncAction branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchWhenAsync<T>(this Task<OperationResult<T>> prevOperationResult, AsyncPredicate<OperationResult<T>> condition, AsyncAction<OperationResult<T>> branchAction)
            => await (await prevOperationResult).BranchWhenAsync(condition, branchAction);
    }
}
