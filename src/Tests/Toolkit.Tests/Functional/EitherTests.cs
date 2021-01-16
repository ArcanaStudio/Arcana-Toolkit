using ArcanaStudio.Toolkit.Functional;
using FluentAssertions;
using NUnit.Framework;

namespace Toolkit.Tests.Functional
{
    [TestFixture]
    public class EitherTests
    {
        [Test]
        public void RightOperatorTest()
        {
            var result = (Either<int,string>)"test";

            result.Should().BeOfType<Right<int,string>>();
        }

        [Test]
        public void LeftOperatorTest()
        {
            var result = (Either<int, string>)10;

            result.Should().BeOfType<Left<int, string>>();
        }

        [Test]
        public void LeftCastTest()
        {
            var result = new Left<int, string>(10);

            ((int)result).Should().Be(10);
        }

        [Test]
        public void RightCastTest()
        {
            var s = "test";

            var result = new Right<int, string>(s);

            ((string)result).Should().Be(s);
        }
    }
}
