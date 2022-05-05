#define A
#define B
#define C

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._08
{
    /// <summary>
    /// 2.8. c# preprocessor directives
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
#if A && B || C
            testOutputHelper.WriteLine("A && B || C");
#endif

            // #pragma 用来启用/禁用某个 compile warning
#pragma warning disable CS1030
#warning 警告
#pragma warning restore CS1030
        }
    }
}
