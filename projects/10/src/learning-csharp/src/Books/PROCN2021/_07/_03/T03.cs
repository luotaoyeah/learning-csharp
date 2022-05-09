namespace Luotao.LearningCsharp.Test.Books.PROCN2021._07._03
{
    namespace _03
    {
        /// <summary>
        /// 7.3.3. closures
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                // 闭包
                Func<int> F01()
                {
                    int x = 6;
                    return () => x;
                }

                Assert.Equal(6, F01()());
            }
        }
    }
}
