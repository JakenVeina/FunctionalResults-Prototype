using System;

using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultGenericTests
{
    [TestFixture]
    public class Constructor_Value
    {
        [Test]
        public void Always_IsSuccess()
        {
            var value = new object();

            var result = new OperationResult<object>(value);

            result.IsSuccess.ShouldBeTrue();
        }

        [Test]
        public void Always_IsNotFailure()
        {
            var value = new object();

            var result = new OperationResult<object>(value);

            result.IsFailure.ShouldBeFalse();
        }

        [Test]
        public void Always_ErrorThrowsException()
        {
            var value = new object();

            var result = new OperationResult<object>(value);

            Should.Throw<InvalidOperationException>(() =>
            {
                var error = result.Error;
            });
        }

        [Test]
        public void Always_ValueIsGiven()
        {
            var value = new object();

            var result = new OperationResult<object>(value);

            result.Value.ShouldBeSameAs(value);
        }
    }
}
