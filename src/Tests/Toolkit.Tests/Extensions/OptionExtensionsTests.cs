using ArcanaStudio.Toolkit.Extensions;
using ArcanaStudio.Toolkit.Functional;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Extensions.TestCasesSource;

namespace Toolkit.Tests.Extensions
{
    [TestFixture]
    public class OptionExtensionsTests
    {
        [Test, TestCaseSource(typeof(OptionExtensionsTestCaseSources), nameof(OptionExtensionsTestCaseSources.HasValue))]
        public void HasValueTests(Option<string> s, bool expected)
        {
            var result = s.HasValue();

            result.Should().Be(expected);
        }
    }
}
