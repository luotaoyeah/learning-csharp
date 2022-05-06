namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._04
{
    namespace _03
    {
        /// <summary>
        /// 3.4.3. positional records
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            // 生成了对应的 constructor
            [Fact]
            public void _01()
            {
                R01 r01 = new(18);
                Assert.Equal(18, r01.Age);
            }

            // 生成了 deconstructor
            [Fact]
            public void _02()
            {
                R02 r01 = new(18, "luotao");
                (int age, string name) = r01;
                Assert.Equal(18, age);
                Assert.Equal("luotao", name);
            }
        }

        public record R01(int Age);

        public record R02(int Age, string Name)
        {
            public int Score;
        }
    }
}
