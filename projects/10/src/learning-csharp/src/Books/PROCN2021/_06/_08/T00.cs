namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._08
{
    namespace _00
    {
        /// <summary>
        /// 6.8. using Span with arrays
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                int[] arr01 = new[] { 1, 2, 3 };

                Span<int> span01 = new Span<int>(arr01);

                span01[1] = 4;

                Assert.Equal(4, arr01[1]);
            }
        }
    }
}
