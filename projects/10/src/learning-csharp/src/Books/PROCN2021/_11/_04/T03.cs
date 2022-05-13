using System.Threading.Tasks;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._11._04
{
    namespace _03
    {
        /// <summary>
        /// 11.4.3. using AggregateException information
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            // Task.Exception
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

                Task? task = null;
                try
                {
                    task = Task.WhenAll(task01, task02, task03);
                    await task;
                }
                catch (Exception e)
                {
                    if (task?.Exception?.InnerExceptions != null)
                    {
                        foreach (Exception exception in task.Exception.InnerExceptions)
                        {
                            testOutputHelper.WriteLine(DateTime.Now + ": " + exception.Message);
                        }
                    }
                }
            }
        }
    }
}
