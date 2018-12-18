using System;

using Moq;
using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultGenericTests
{
    [TestFixture]
    public class Constructor_Error
    {
        [Test]
        public void ErrorIsNull_ThrowsException()
        {
            Should.Throw<ArgumentNullException>(() =>
                new OperationResult<object>(null));
        }

        [Test]
        public void Otherwise_IsFailure()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult<object>(error);

            result.IsFailure.ShouldBeTrue();
        }

        [Test]
        public void Otherwise_IsNotSuccess()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult<object>(error);

            result.IsSuccess.ShouldBeFalse();
        }

        [Test]
        public void Otherwise_ErrorIsGiven()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult<object>(error);

            result.Error.ShouldBeSameAs(error);
        }

        [Test]
        public void Otherwise_ValueThrowsException()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult<object>(error);

            Should.Throw<InvalidOperationException>(() =>
            {
                var value = result.Value;
            });
        }
    }
}
