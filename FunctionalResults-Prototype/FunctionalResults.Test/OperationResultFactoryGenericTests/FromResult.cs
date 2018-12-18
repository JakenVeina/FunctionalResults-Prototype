using System;

using NUnit.Framework;
using Shouldly;

namespace FunctionalResults.Test.OperationResultFactoryGenericTests
{
    [TestFixture]
    public class FromResult
    {
        [Test]
        public void Always_ResultIsSuccess()
        {
            var value = new object();

            var result = OperationResult<object>.FromResult(value);

            result.IsSuccess.ShouldBeTrue();
        }

        [Test]
        public void Always_ResultIsNotFailure()
        {
            var value = new object();

            var result = OperationResult<object>.FromResult(value);

            result.IsFailure.ShouldBeFalse();
        }

        [Test]
        public void Always_ResultErrorThrowsException()
        {
            var value = new object();

            var result = OperationResult<object>.FromResult(value);

            Should.Throw<InvalidOperationException>(() =>
            {
                var error = result.Error;
            });
        }

        [Test]
        public void Always_ResultValueIsGiven()
        {
            var value = new object();

            var result = OperationResult<object>.FromResult(value);

            result.Value.ShouldBeSameAs(value);
        }
    }
}
