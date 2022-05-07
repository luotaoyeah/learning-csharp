namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._07
{
    namespace _04
    {
        /// <summary>
        /// 3.7.4. out parameters
        /// </summary>
        public class T04
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T04(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                string str01 = "6";

                // 在调用方法的同时, 声明 out 参数 i
                if (int.TryParse(str01, out int i))
                {
                    testOutputHelper.WriteLine("{0}", i);
                    Assert.Equal(6, i);
                }

                // 先声明 out 参数 j, 再调用方法
                int j;
                if (int.TryParse(str01, out j))
                {
                    testOutputHelper.WriteLine("{0}", j);
                    Assert.Equal(6, j);
                }
            }
        }
    }
}
