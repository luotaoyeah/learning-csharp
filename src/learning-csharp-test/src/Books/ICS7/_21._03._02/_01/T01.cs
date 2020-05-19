using System.Threading.Tasks;
using LuotaoYeah.Lib.Books.ICS7._21._03._02._01;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._21._03._02._01
{
    /// <summary>
    ///     21.3.2.1 exception handling and the await expression
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            Task task = new MyClass(testOutputHelper.WriteLine).BadAsync();
            task.Wait();

            //----------------------------------------------------------------------------------------------------
            // 由于 Task 没有被 cancel，并且它里面的异常被处理掉了，因此它的 Status 为 TaskStatus.RanToCompletion
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(TaskStatus.RanToCompletion, task.Status);
            Assert.False(task.IsFaulted);
        }
    }
}
