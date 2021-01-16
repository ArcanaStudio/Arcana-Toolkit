using ArcanaStudio.Toolkit.Extensions;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Extensions.TestCasesSource;

namespace Toolkit.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test, TestCaseSource(typeof(StringExtensionsTestCasesSource), nameof(StringExtensionsTestCasesSource.IsNullOrEmpty))]
        public void IsNullOrEmptyTests(string s, bool expected)
        {
            var result = s.IsNullOrEmpty();

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(StringExtensionsTestCasesSource), nameof(StringExtensionsTestCasesSource.IsNotNullOrEmpty))]
        public void IsNotNullOrEmptyTests(string s, bool expected)
        {
            var result = s.IsNotNullOrEmpty();

            result.Should().Be(expected);
        }
    }
}
