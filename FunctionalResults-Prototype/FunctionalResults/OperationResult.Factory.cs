﻿using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public partial class OperationResult
    {
        public static OperationResult Success { get; }
            = new OperationResult();

        public static OperationResult<TResult> Combine<T1, T2, TResult>(OperationResult<T1> operationResult1, OperationResult<T2> operationResult2, Func<T1, T2, TResult> combiner)
            => operationResult1.AssertNotNull(nameof(operationResult1)).IsFailure ? OperationResult<TResult>.FromError(operationResult1.Error)
                : operationResult2.AssertNotNull(nameof(operationResult2)).IsFailure ? OperationResult<TResult>.FromError(operationResult2.Error)
                : OperationResult<TResult>.FromResult(combiner.AssertNotNull(nameof(combiner)).Invoke(operationResult1.Value, operationResult2.Value));

        public static async Task<OperationResult<TResult>> Combine<T1, T2, TResult>(Task<OperationResult<T1>> operation1, Task<OperationResult<T2>> operation2, Func<T1, T2, TResult> combiner)
            => Combine(await operation1.AssertNotNull(nameof(operation1)), await operation2.AssertNotNull(nameof(operation2)), combiner);

        public static OperationResult FromError(IOperationError error)
            => new OperationResult(error);

        public static OperationResult<T> FromResult<T>(T value)
            => new OperationResult<T>(value);
    }
}
