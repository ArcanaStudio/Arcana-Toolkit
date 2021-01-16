using System;

namespace ArcanaStudio.Toolkit.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetInnerMessage(this Exception e)
        {
            while (true)
            {
                if (e.InnerException.IsNull()) return e.Message;
                e = e.InnerException;
            }
        }
    }
}
