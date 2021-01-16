using System.Collections.Generic;

namespace Toolkit.Tests.Extensions.TestCasesSource
{
    public static class StringExtensionsTestCasesSource
    {
        public static IEnumerable<object[]> IsNullOrEmpty
        {
            get
            {
                yield return new  object[] {null, true};
                yield return new  object[] {string.Empty, true};
                yield return new  object[] {" ", false};
                yield return new  object[] {"abc", false};
                yield return new  object[] {" abc ", false};
            }
        }

        public static IEnumerable<object[]> IsNotNullOrEmpty
        {
            get
            {
                yield return new object[] { null, false };
                yield return new object[] { string.Empty, false };
                yield return new object[] { " ", true };
                yield return new object[] { "abc", true };
                yield return new object[] { " abc ", true };
            }
        }
    }
}
