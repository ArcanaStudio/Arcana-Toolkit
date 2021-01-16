using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Toolkit.Tests.Extensions.TestCasesSource
{
    public static class TaskExtensionsTestCasesSource
    {
        public static IEnumerable<object[]> IsSucceed
        {
            get
            {
                yield return new  object[] {Task.CompletedTask, true};
                yield return new  object[] {Task.FromCanceled(new CancellationToken(true)), false};
                yield return new  object[] {Task.FromException(new NotImplementedException()), false};
            }
        }

        public static IEnumerable<object[]> IsNotSucceed
        {
            get
            {
                yield return new object[] { Task.CompletedTask, false };
                yield return new object[] { Task.FromCanceled(new CancellationToken(true)), true };
                yield return new object[] { Task.FromException(new NotImplementedException()), true };
            }
        }

        public static IEnumerable<object[]> Continue
        {
            get
            {
                yield return new object[] { Task.CompletedTask, new ActionsClass(), true,false,false };
                yield return new object[] { Task.FromException(new NotImplementedException()), new ActionsClass(), false, true, false };
                yield return new object[] { Task.FromCanceled(new CancellationToken(true)), new ActionsClass(), false, false, true };
            }
        }

        public static IEnumerable<object[]> ContinueGeneric()
        {
            yield return new object[] { Task.FromResult(new object()), new ActionsClass<object>(), true, false, false };
            yield return new object[] { Task.FromException<object>(new NotImplementedException()), new ActionsClass<object>(), false, true, false };
            yield return new object[] { Task.FromCanceled<object>(new CancellationToken(true)), new ActionsClass<object>(), false, false, true };
        }
    }

    public class ActionsClass
    {
        public Action Success => () => IsSuccessCalled = true;
        public bool IsSuccessCalled { get; private set; }
        public Action Failed => () => IsFailedCalled = true;
        public bool IsFailedCalled { get; private set; }
        public Action Canceled => () => IsCanceledCalled = true;
        public bool IsCanceledCalled { get; private set; }
    }

    public class ActionsClass<T> where T : class
    {
        private T _param;

        public Action<T> Success => (o) => _param = o;
        public bool IsSuccessCalled => _param != default(T);
        public Action Failed => () => IsFailedCalled = true;
        public bool IsFailedCalled { get; private set; }
        public Action Canceled => () => IsCanceledCalled = true;
        public bool IsCanceledCalled { get; private set; }
    }
}
