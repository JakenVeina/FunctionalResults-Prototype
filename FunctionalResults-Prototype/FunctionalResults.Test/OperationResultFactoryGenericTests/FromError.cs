using System;

using Moq;
using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultFactoryGenericTests
{
    [TestFixture]
    public class FromError
    {
        [Test]
        public void ErrorIsNull_ThrowsException()
        {
            Should.Throw<ArgumentNullException>(() =>
                OperationResult<object>.FromError(null));
        }

        [Test]
        public void Otherwise_ResultIsFailure()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult<object>.FromError(error);

            result.IsFailure.ShouldBeTrue();
        }

        [Test]
        public void Otherwise_ResultIsNotSuccess()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult<object>.FromError(error);

            result.IsSuccess.ShouldBeFalse();
        }

        [Test]
        public void Otherwise_ResultErrorIsGiven()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult<object>.FromError(error);

            result.Error.ShouldBeSameAs(error);
        }

        [Test]
        public void Otherwise_ResultValueThrowsException()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult<object>.FromError(error);

            Should.Throw<InvalidOperationException>(() =>
            {
                var value = result.Value;
            });
        }
    }
}
