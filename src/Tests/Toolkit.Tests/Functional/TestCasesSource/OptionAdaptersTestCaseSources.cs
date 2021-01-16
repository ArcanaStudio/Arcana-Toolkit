using System;
using System.Collections.Generic;
using ArcanaStudio.Toolkit.Extensions;
using ArcanaStudio.Toolkit.Functional;

namespace Toolkit.Tests.Functional.TestCasesSource
{
    public static class OptionAdaptersTestCaseSources
    {
        public static IEnumerable<object[]> MapFunc
        {
            get
            {
                var func = new Func<string,int>(s => s.Length);
                yield return new object[] { new Some<string>(string.Empty), func, 0};
                yield return new object[] { new Some<string>("test"), func, 4};
            }
        }

        public static IEnumerable<object[]> Map
        {
            get
            {
                var func = new Func<string, int>(s => s.Length);
                yield return new object[] { new Some<string>(string.Empty), func, typeof(Some<int>)};
                yield return new object[] { new None<string>(), func, typeof(None<int>)};
            }
        }

        public static IEnumerable<object[]> When
        {
            get
            {
                var func = new Func<string, bool>(s => s.IsNotNullOrEmpty());
                yield return new object[] { (string)null, func, false };
                yield return new object[] { string.Empty, func, false };
                yield return new object[] { "test", func, true };
            }
        }        
        
        public static IEnumerable<object[]> ReduceTest
        {
            get
            {
                yield return new object[] { new Some<int>(10), -1, 10 };
                yield return new object[] { new None<int>(), -1, -1 };
            }
        }        
        
        public static IEnumerable<object[]> ReduceLazyTest
        {
            get
            {
                var func = new Func<int>(() => -1);
                yield return new object[] { new Some<int>(10), func, 10 };
                yield return new object[] { new None<int>(), func, -1 };
            }
        }
    }
}
