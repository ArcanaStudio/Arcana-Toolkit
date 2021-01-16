using System;
using ArcanaStudio.Toolkit.Extensions;
using ArcanaStudio.Toolkit.Functional;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Functional.TestCasesSource;

namespace Toolkit.Tests.Functional
{
    [TestFixture]
    public class OptionAdaptersTests
    {
        [Test, TestCaseSource(typeof(OptionAdaptersTestCaseSources), nameof(OptionAdaptersTestCaseSources.MapFunc))]
        public void MapFuncTest(Some<string> option, Func<string,int> func, int expected)
        {
            var result = option.Map(func) as Some<int>;

            result.Should().NotBeNull();
            ((int)result).Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(OptionAdaptersTestCaseSources), nameof(OptionAdaptersTestCaseSources.Map))]
        public void MapTest(Option<string> option, Func<string, int> func, Type expected)
        {
            var result = option.Map(func);

            result.Should().BeOfType(expected);
        }

        [Test, TestCaseSource(typeof(OptionAdaptersTestCaseSources), nameof(OptionAdaptersTestCaseSources.When))]
        public void WhenTest(string option, Func<string, bool> predicate, bool expected)
        {
            var result = option.When(predicate);

            result.HasValue().Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(OptionAdaptersTestCaseSources), nameof(OptionAdaptersTestCaseSources.ReduceTest))]
        public void ReduceTest(Option<int> option, int whennone, int expected)
        {
            var result = option.Reduce(whennone);

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(OptionAdaptersTestCaseSources), nameof(OptionAdaptersTestCaseSources.ReduceLazyTest))]
        public void ReduceLazyTest(Option<int> option, Func<int> whennone, int expected)
        {
            var result = option.Reduce(whennone);

            result.Should().Be(expected);
        }
    }
}
