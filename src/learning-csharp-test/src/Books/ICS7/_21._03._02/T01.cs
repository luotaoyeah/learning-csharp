using System.Threading;
using System.Threading.Tasks;
using Luotao.Lib.Books.ICS7._21._03._02;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._21._03._02
{
    /// <summary>
    ///     21.3.2 cancelling an async operation
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
            CancellationTokenSource cancellationTokenSource = new();

            var myClass = new MyClass(testOutputHelper.WriteLine);
            Task task = myClass.RunAsync(cancellationTokenSource.Token);

            Thread.Sleep(3000);
            cancellationTokenSource.Cancel();

            task.Wait();
        }
    }
}
