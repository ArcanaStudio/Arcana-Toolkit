using System.Collections.Generic;
using ArcanaStudio.Toolkit.Functional;

namespace Toolkit.Tests.Extensions.TestCasesSource
{
    public static class OptionExtensionsTestCaseSources
    {
        public static IEnumerable<object[]> HasValue
        {
            get
            {
                yield return new object[] { null, false };
                yield return new object[] { (Option<string>)None.Value, false };
                yield return new object[] { new Some<string>("test"), true };
            }
        }
    }
}
