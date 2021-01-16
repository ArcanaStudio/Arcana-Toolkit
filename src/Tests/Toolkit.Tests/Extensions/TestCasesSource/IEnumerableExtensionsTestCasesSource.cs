using System.Collections.Generic;
using System.Linq;

namespace Toolkit.Tests.Extensions.TestCasesSource
{
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableExtensionsTestCasesSource
    {
        public static IEnumerable<object[]> ExecuteForEach
        {
            get
            {
                var list = new List<int> {1, 2, 3, 4};
                yield return new  object[] {new List<int>(), 0};
                yield return new  object[] {list, list.Sum()};
                yield return new  object[] {null, 0};
            }
        }        
        
        public static IEnumerable<object[]> IsEmpty
        {
            get
            {
                yield return new  object[] {new List<int>(), true};
                yield return new  object[] {new List<int>{ 1 }, false};
            }
        }

        public static IEnumerable<object[]> IsNotEmpty
        {
            get
            {
                yield return new object[] { new List<int>(), false };
                yield return new object[] { new List<int> { 1 }, true };
            }
        }
    }
}
