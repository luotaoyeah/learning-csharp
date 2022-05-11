namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _03
    {
        /// <summary>
        /// 9.2.3. type filtering
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
                object[] items = { 1, 2, "3", 4, "5", 6 };

                var query = items.OfType<string>();

                foreach (string s in query)
                {
                    testOutputHelper.WriteLine(s);
                }
            }
        }
    }
}
