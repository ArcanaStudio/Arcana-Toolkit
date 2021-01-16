using System.Text.RegularExpressions;

namespace ArcanaStudio.Toolkit.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNotNullOrEmpty(this string s)
        {
            return !s.IsNullOrEmpty();
        }

        public static string ToCamelCase(this string s)
        {
            return Regex.Replace(s, @"([A-Z])([A-Z]+|[a-z0-9_]+)($|[A-Z]\w*)",
            m => m.Groups[1].Value.ToLower() + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
        }
    }
}
