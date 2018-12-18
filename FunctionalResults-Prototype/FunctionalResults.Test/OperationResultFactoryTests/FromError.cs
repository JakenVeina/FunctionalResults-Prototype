using System;

using Moq;
using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultFactoryTests
{
    [TestFixture]
    public class FromError
    {
        [Test]
        public void ErrorIsNull_ThrowsException()
        {
            Should.Throw<ArgumentNullException>(() =>
                OperationResult.FromError(null));
        }

        [Test]
        public void Otherwise_ResultIsFailure()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult.FromError(error);

            result.IsFailure.ShouldBeTrue();
        }

        [Test]
        public void Otherwise_ResultIsNotSuccess()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult.FromError(error);

            result.IsSuccess.ShouldBeFalse();
        }

        [Test]
        public void Otherwise_ResultErrorIsGiven()
        {
            var error = new Mock<IOperationError>().Object;

            var result = OperationResult.FromError(error);

            result.Error.ShouldBeSameAs(error);
        }
    }
}
