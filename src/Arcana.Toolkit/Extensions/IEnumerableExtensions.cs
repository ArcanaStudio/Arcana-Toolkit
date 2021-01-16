using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcanaStudio.Toolkit.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableExtensions
    {
        public static void ExecuteForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            if (list.IsNull())
                return;

            foreach (var item in list)
            {
                action?.Invoke(item);
            }
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> list)
        {
            return list.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> list)
        {
            return !list.Any();
        }
    }
}
