using ArcanaStudio.Toolkit.Functional;

namespace ArcanaStudio.Toolkit.Extensions
{
    public static class OptionExtensions
    {
        public static bool HasValue<T>(this Option<T> option)
        {
            return !option.IsNull() && !(option is None<T>);
        }
    }
}
