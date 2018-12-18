using System;

using Moq;
using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultTests
{
    [TestFixture]
    public class Constructor_Error
    {
        [Test]
        public void ErrorIsNull_ThrowsException()
        {
            Should.Throw<ArgumentNullException>(() => 
                new OperationResult(null));
        }

        [Test]
        public void Otherwise_IsFailure()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult(error);

            result.IsFailure.ShouldBeTrue();
        }

        [Test]
        public void Otherwise_IsNotSuccess()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult(error);

            result.IsSuccess.ShouldBeFalse();
        }

        [Test]
        public void Otherwise_ErrorIsGiven()
        {
            var error = new Mock<IOperationError>().Object;

            var result = new OperationResult(error);

            result.Error.ShouldBeSameAs(error);
        }
    }
}
