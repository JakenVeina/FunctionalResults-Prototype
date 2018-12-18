using System;

namespace FunctionalResults
{
    public class OperationResult<T> : OperationResult
    {
        public static OperationResult<T> FromResult(T value)
            => new OperationResult<T>(value);

        new public static OperationResult<T> FromError(IOperationError error)
            => new OperationResult<T>(error);

        internal protected OperationResult(T value)
			: base()
		{
            _value = value;
		}

		internal protected OperationResult(IOperationError error)
			: base(error) { }

		public T Value
			=> IsSuccess ? _value
                : throw new InvalidOperationException("Cannot retrieve result data for a failed operation");
        private readonly T _value;
    }
}
