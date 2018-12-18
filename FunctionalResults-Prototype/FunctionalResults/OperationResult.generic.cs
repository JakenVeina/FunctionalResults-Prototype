using System;

namespace FunctionalResults
{
    public partial class OperationResult<T> : OperationResult
    {
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
