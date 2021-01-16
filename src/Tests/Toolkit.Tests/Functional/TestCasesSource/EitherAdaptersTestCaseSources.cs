using System;
using System.Collections.Generic;
using ArcanaStudio.Toolkit.Functional;

namespace Toolkit.Tests.Functional.TestCasesSource
{
    public static class EitherAdaptersTestCaseSources
    {
        public static IEnumerable<object[]> MapFuncTest
        {
            get
            {
                var s = "test";
                var func = new Func<string, int>(s => s.Length);
                yield return new object[] { new Left<double,string>(10), func, typeof(Left<double, int>)  };
                yield return new object[] { new Right<double, string>(s), func, typeof(Right<double, int>) };
            }
        }

        public static IEnumerable<object[]> MapLazyFuncTest
        {
            get
            {
                var s = "test";
                var func = new Func<string, Either<double,int>>(s => s.Length);
                yield return new object[] { new Left<double, string>(10), func, typeof(Left<double, int>) };
                yield return new object[] { new Right<double, string>(s), func, typeof(Right<double, int>) };
            }
        }

        public static IEnumerable<object[]> ReduceTest
        {
            get
            {
                var s = "test";
                var func = new Func<int, string>(s => s.ToString());
                yield return new object[] { new Left<int, string>(10), func, "10" };
                yield return new object[] { new Right<int, string>(s), func, s };
            }
        }
    }
}