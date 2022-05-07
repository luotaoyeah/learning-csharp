namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._11
{
    namespace _01
    {
        /// <summary>
        /// 3.11.1. pattern matching with tuples
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
                int F01(string name, int age)
                {
                    return (name, age) switch
                    {
                        ("luotao", 18) => 0,
                        ("owen", 20) => 1,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                }

                Assert.Equal(0, F01("luotao", 18));
                Assert.Equal(1, F01("owen", 20));
            }
        }
    }
}
