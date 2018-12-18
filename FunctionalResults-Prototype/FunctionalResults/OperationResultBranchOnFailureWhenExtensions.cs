﻿using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class OperationResultBranchOnFailureWhenExtensions
    {
        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    branchAction);
            
        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static OperationResult BranchOnFailureWhen(this OperationResult currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, bool condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    branchAction);

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, Predicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static OperationResult<T> BranchOnFailureWhen<T>(this OperationResult<T> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhen(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult> BranchOnFailureWhenAsync(this OperationResult currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition,
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(x => x.IsFailure && condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    branchAction);

        public static Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this OperationResult<T> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => currentOperationResult
                .BranchWhenAsync(async x => x.IsFailure && await condition.AssertNotNull(nameof(condition))
                        .Invoke(x.Error),
                    x => branchAction.AssertNotNull(nameof(branchAction))
                        .Invoke(x.Error));

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult> BranchOnFailureWhenAsync(this Task<OperationResult> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, bool condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, Action branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, Action<IOperationError> branchAction)
            => (await currentOperationResult)
                .BranchOnFailureWhen(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, Predicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, Action branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, Action<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);

        public static async Task<OperationResult<T>> BranchOnFailureWhenAsync<T>(this Task<OperationResult<T>> currentOperationResult, AsyncPredicate<IOperationError> condition, AsyncAction<IOperationError> branchAction)
            => await (await currentOperationResult)
                .BranchOnFailureWhenAsync(condition, branchAction);
    }
}
