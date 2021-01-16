using System.Threading.Tasks;
using ArcanaStudio.Toolkit.Extensions;
using FluentAssertions;
using NUnit.Framework;
using Toolkit.Tests.Extensions.TestCasesSource;

namespace Toolkit.Tests.Extensions
{
    [TestFixture]
    public class TaskExtensionsTests
    {
        [Test, TestCaseSource(typeof(TaskExtensionsTestCasesSource), nameof(TaskExtensionsTestCasesSource.IsSucceed))]
        public void IsSucceedTests(Task t, bool expected)
        {
            var result = t.IsSucceed();

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(TaskExtensionsTestCasesSource), nameof(TaskExtensionsTestCasesSource.IsNotSucceed))]
        public void IsNotSucceedTests(Task t, bool expected)
        {
            var result = t.IsNotSucceed();

            result.Should().Be(expected);
        }

        [Test, TestCaseSource(typeof(TaskExtensionsTestCasesSource), nameof(TaskExtensionsTestCasesSource.Continue))]
        public void ContinueTests(Task t, ActionsClass actions, bool expectedsuccess, bool expectedfail, bool expectedcanceled)
        {
            t.Continue(actions.Success, actions.Failed, actions.Canceled);

            actions.IsSuccessCalled.Should().Be(expectedsuccess);
            actions.IsFailedCalled.Should().Be(expectedfail);
            actions.IsCanceledCalled.Should().Be(expectedcanceled);
        }

        [Test, TestCaseSource(typeof(TaskExtensionsTestCasesSource), nameof(TaskExtensionsTestCasesSource.ContinueGeneric))]
        public void ContinueGenericTests(Task<object> t, ActionsClass<object> actions, bool expectedsuccess, bool expectedfail, bool expectedcanceled)
        {
            t.Continue(o => actions.Success(o), actions.Failed, actions.Canceled);

            actions.IsSuccessCalled.Should().Be(expectedsuccess);
            actions.IsFailedCalled.Should().Be(expectedfail);
            actions.IsCanceledCalled.Should().Be(expectedcanceled);
        }
    }
}
