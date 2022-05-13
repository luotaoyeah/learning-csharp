using System.Threading.Tasks;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._11._04
{
    namespace _02
    {
        /// <summary>
        /// 11.4.2. handling exceptions with multiple asynchronous methods
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public async Task _01()
            {
                Task task01 = Task.Run(
                    async () =>
                    {
                        await Task.Delay(1000);
                        throw new Exception("ERROR A");
                    }
                );

                Task task02 = Task.Run(
                    async () =>
                    {
                        await Task.Delay(2000);
                        throw new Exception("ERROR B");
                    }
                );

                Task task03 = Task.Run(
                    async () =>
                    {
                        await Task.Delay(3000);
                        testOutputHelper.WriteLine(DateTime.Now + ": C");
                    }
                );

                testOutputHelper.WriteLine(DateTime.Now + ": ----------");
                try
                {
                    // task03 会正常执行完毕
                    await Task.WhenAll(task01, task02, task03);
                }
                catch (Exception e)
                {
                    // task01 抛出的异常会被捕获, 因为它是 WhenAll() 参数列表中第一个抛出异常的任务
                    testOutputHelper.WriteLine(DateTime.Now + ": " + e.Message);
                }
            }
        }
    }
}
