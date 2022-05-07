namespace Luotao.LearningCsharp.Test.Books.PROCN2021._04._05
{
    namespace _01
    {
        /// <summary>
        /// 4.5.1. predefined interfaces
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
                using (C01 c01 = new())
                {
                }
            }
        }

        class C01 : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}
