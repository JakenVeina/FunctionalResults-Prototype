using System;

namespace FunctionalResults
{
    public partial class OperationResult
    {
        internal protected OperationResult()
        {
            IsSuccess = true;
        }

        internal protected OperationResult(IOperationError error)
        {
            IsSuccess = false;
            _error = error ?? throw new ArgumentNullException(nameof(error));
        }

        public bool IsSuccess { get; }

        public bool IsFailure
            => !IsSuccess;

        public IOperationError Error
            => !IsSuccess ? _error
                : throw new InvalidOperationException("Cannot retrieve error data for a successful operation");
        private readonly IOperationError _error;
    }
}
