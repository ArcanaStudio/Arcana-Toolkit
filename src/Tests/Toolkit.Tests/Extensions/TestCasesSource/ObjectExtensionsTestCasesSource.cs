using System.Collections.Generic;

namespace Toolkit.Tests.Extensions.TestCasesSource
{
    public static class ObjectExtensionsTestCasesSource
    {
        public static IEnumerable<object[]> IsNull
        {
            get
            {
                yield return new  object[] {null, true};
                yield return new  object[] {string.Empty, false};
                yield return new  object[] {1, false};
                yield return new  object[] {new object(), false};
            }
        }

        public static IEnumerable<object[]> IsNotNull
        {
            get
            {
                yield return new object[] { null, false };
                yield return new object[] { string.Empty, true };
                yield return new object[] { 1, true };
                yield return new object[] { new object(), true };
            }
        }
    }
}
