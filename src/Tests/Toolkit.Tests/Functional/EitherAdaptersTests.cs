using System;
using ArcanaStudio.Toolkit.Functional;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Functional.TestCasesSource;

namespace Toolkit.Tests.Functional
{
    [TestFixture]
    public class EitherAdaptersTests
    {
        [Test, TestCaseSource(typeof(EitherAdaptersTestCaseSources), nameof(EitherAdaptersTestCaseSources.MapFuncTest))]
        public void MapFuncTest(Either<double, string> either, Func<string, int> func, Type expectedtype)
        {
            var result = either.Map(func);

            result.Should().BeOfType(expectedtype);
        }

        [Test, TestCaseSource(typeof(EitherAdaptersTestCaseSources), nameof(EitherAdaptersTestCaseSources.MapLazyFuncTest))]
        public void MapLazyFuncTest(Either<double, string> either, Func<string, Either<double, int>> func, Type expectedtype)
        {
            var result = either.Map(func);

            result.Should().BeOfType(expectedtype);
        }

        [Test, TestCaseSource(typeof(EitherAdaptersTestCaseSources), nameof(EitherAdaptersTestCaseSources.ReduceTest))]
        public void ReduceTest(Either<int, string> either, Func<int, string> func, string expected)
        {
            var result = either.Reduce(func);

            result.Should().Be(expected);
        }
    }
}
