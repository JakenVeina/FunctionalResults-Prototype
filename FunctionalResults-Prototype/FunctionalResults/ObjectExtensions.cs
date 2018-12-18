using System;
using System.Threading.Tasks;

namespace FunctionalResults
{
    public static class ObjectExtensions
    {
        public static T AssertNotNull<T>(this T value, string valueName) where T : class
            => (value is null)
                ? throw new ArgumentNullException(valueName)
                : value;

        public static OperationResult<T> AsSuccess<T>(this T value)
            => OperationResult<T>.FromResult(value);

        public static async Task<OperationResult<T>> AsSuccessAsync<T>(this Task<T> value)
            => OperationResult<T>.FromResult(await value);
    }
}
