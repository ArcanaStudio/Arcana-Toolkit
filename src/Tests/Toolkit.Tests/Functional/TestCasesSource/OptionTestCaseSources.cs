using System.Collections.Generic;
using ArcanaStudio.Toolkit.Functional;

namespace Toolkit.Tests.Functional.TestCasesSource
{
    public static class OptionTestCaseSources
    {
        public static IEnumerable<object[]> ValueTest
        {
            get
            {
                var s = "test";
                yield return new object[] { new Some<string>(s), s };
            }
        }
    }
}
