using System;

using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultTests
{
    [TestFixture]
    public class Constructor
    {
        [Test]
        public void Always_IsSuccess()
        {
            var uut = new OperationResult();

            uut.IsSuccess.ShouldBeTrue();
        }

        [Test]
        public void Always_IsNotFailure()
        {
            var uut = new OperationResult();

            uut.IsFailure.ShouldBeFalse();
        }

        [Test]
        public void Always_ErrorThrowsException()
        {
            var uut = new OperationResult();

            Should.Throw<InvalidOperationException>(() =>
            {
                var error = uut.Error;
            });
        }
    }
}
