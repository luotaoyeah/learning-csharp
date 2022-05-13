using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._11._03
{
    namespace _00
    {
        /// <summary>
        /// 11.3. tasks
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public async Task _01()
            {
                Trace("before: " + nameof(_01));
                await GreetingAsync();
                Trace("after: " + nameof(_01));
            }

            // GetAwaiter()
            [Fact(Timeout = 4000)]
            public void _02()
            {
                Trace("before: " + nameof(_01));
                TaskAwaiter<string> taskAwaiter = GreetingAsync().GetAwaiter();
                taskAwaiter.OnCompleted(() => { testOutputHelper.WriteLine(nameof(taskAwaiter.OnCompleted)); });
                Trace("after: " + nameof(_01));
            }

            // ContinueWith()
            [Fact]
            public async Task _03()
            {
                Trace("before: " + nameof(_01));
                await GreetingAsync().ContinueWith((task) => Trace(nameof(Task.ContinueWith)));
                Trace("after: " + nameof(_01));
            }

            private void Trace(string message = "")
            {
                testOutputHelper.WriteLine("THREAD: [{0,-6}], TASK: [{1,-6}], {2}", Thread.CurrentThread.ManagedThreadId, Task.CurrentId, message);
            }

            private string Greeting()
            {
                Trace(nameof(Greeting));
                Task.Delay(2000).Wait();
                return string.Empty;
            }

            private Task<string> GreetingAsync()
            {
                return Task.Run(
                    () =>
                    {
                        Trace(nameof(GreetingAsync));
                        return Greeting();
                    }
                );
            }
        }
    }
}
