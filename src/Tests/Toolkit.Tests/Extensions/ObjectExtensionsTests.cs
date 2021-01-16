using ArcanaStudio.Toolkit.Extensions;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Extensions.TestCasesSource;

namespace Toolkit.Tests.Extensions
{
    [TestFixture]
    public class ObjectExtensionsTests
    {
        [Test, TestCaseSource(typeof(ObjectExtensionsTestCasesSource), nameof(ObjectExtensionsTestCasesSource.IsNull))]
        public void IsNullTests(object o, bool expected)
        {
            var result = o.IsNull();

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(ObjectExtensionsTestCasesSource), nameof(ObjectExtensionsTestCasesSource.IsNotNull))]
        public void IsNotNullTests(object o, bool expected)
        {
            var result = o.IsNotNull();

            result.Should().Be(expected);
        }
    }
}
