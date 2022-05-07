namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._08
{
    namespace _03
    {
        /// <summary>
        /// 3.8.3. returning tuples
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
                (string, int) F01()
                {
                    return ("luotao", 18);
                }

                var person = F01();
                Assert.Equal("luotao", person.Item1);
                Assert.Equal(18, person.Item2);
            }
        }
    }
}
