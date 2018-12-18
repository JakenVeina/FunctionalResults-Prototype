using System;

using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultFactoryTests
{
    [TestFixture]
    public class Success
    {
        [Test]
        public void Always_IsSuccess()
        {
            OperationResult.Success.IsSuccess.ShouldBeTrue();
        }

        [Test]
        public void Always_IsNotFailure()
        {
            OperationResult.Success.IsFailure.ShouldBeFalse();
        }

        [Test]
        public void Always_ErrorThrowsException()
        {
            Should.Throw<InvalidOperationException>(() =>
            {
                var error = OperationResult.Success.Error;
            });
        }
    }
}
