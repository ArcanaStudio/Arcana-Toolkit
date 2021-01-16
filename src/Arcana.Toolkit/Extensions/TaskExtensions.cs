using System;
using System.Threading.Tasks;

namespace ArcanaStudio.Toolkit.Extensions
{
    public static class TaskExtensions
    {
        public static bool IsSucceed(this Task t)
        {
            return t.Status == TaskStatus.RanToCompletion;
        }

        public static bool IsNotSucceed(this Task t)
        {
            return t.Status == TaskStatus.Canceled || t.Status == TaskStatus.Faulted;
        }

        public static void Continue(this Task t, Action succeddAction, Action faultAction = null,
            Action canceledAction = null)
        {
            switch (t.Status)
            {
                case TaskStatus.RanToCompletion:
                    succeddAction?.Invoke();
                    break;
                case TaskStatus.Canceled:
                    canceledAction?.Invoke();
                    break;
                case TaskStatus.Faulted:
                    faultAction?.Invoke();
                    break;
            }
        }

        public static void Continue<T>(this Task<T> t, Action<T> succeddAction, Action faultAction = null,
            Action canceledAction = null)
        {
            switch (t.Status)
            {
                case TaskStatus.RanToCompletion:
                    succeddAction?.Invoke(t.Result);
                    break;
                case TaskStatus.Canceled:
                    canceledAction?.Invoke();
                    break;
                case TaskStatus.Faulted:
                    faultAction?.Invoke();
                    break;
            }
        }
    }
}
