namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _06
    {
        /// <summary>
        /// 3.3.6. local functions
        /// </summary>
        public class T06
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T06(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                int a = 0;

                // 在 method 里面定义的 function 称为 local function,
                static int Fn01(int x, int y)
                {
                    return x + y;
                }

                int Fn02()
                {
                    return a;
                }
            }
        }
    }
}
