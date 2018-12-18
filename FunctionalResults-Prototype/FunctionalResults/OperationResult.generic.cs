using System;

namespace FunctionalResults
{
	public interface IOperationResult<T> : IOperationResult
    {
		T Value { get; }
    }

    public class OperationResult<T> : OperationResult, IOperationResult<T>
    {
        public static IOperationResult<T> FromResult(T value)
            => new OperationResult<T>(value);

        new 
            public static IOperationResult<T> FromError(IOperationError error)
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
