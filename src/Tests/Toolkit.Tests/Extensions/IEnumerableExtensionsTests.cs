using System.Collections.Generic;
using ArcanaStudio.Toolkit.Extensions;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Extensions.TestCasesSource;

namespace Toolkit.Tests.Extensions
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class IEnumerableExtensionsTests
    {
        [Test, TestCaseSource(typeof(IEnumerableExtensionsTestCasesSource), nameof(IEnumerableExtensionsTestCasesSource.ExecuteForEach))]
        public void ExecuteForEachTests(IEnumerable<int> l, int expected)
        {
            var result = 0;

            l.ExecuteForEach(i => result+=i);

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(IEnumerableExtensionsTestCasesSource), nameof(IEnumerableExtensionsTestCasesSource.IsEmpty))]
        public void IsEmptyTests(IEnumerable<int> l, bool expected)
        {
            var result = l.IsEmpty();

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(IEnumerableExtensionsTestCasesSource), nameof(IEnumerableExtensionsTestCasesSource.IsNotEmpty))]
        public void IsNotEmptyTests(IEnumerable<int> l, bool expected)
        {
            var result = l.IsNotEmpty();

            result.Should().Be(expected);
        }
    }
}
