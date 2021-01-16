using ArcanaStudio.Toolkit.Functional;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Functional.TestCasesSource;

namespace Toolkit.Tests.Functional
{
    [TestFixture]
    public class OptionTests
    {
        [Test, TestCaseSource(typeof(OptionTestCaseSources), nameof(OptionTestCaseSources.ValueTest))]
        public void ValueTest(Some<string> option, string expected)
        {
            var result = (string)option;

            result.Should().Be(expected);
        }
    }
}
