namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._04
{
    namespace _04
    {
        /// <summary>
        /// 3.4.4. with expressions
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
                R01 r01 = new("luotao", 18);
                Assert.Equal("R01 { Name = luotao, Age = 18 }", r01.ToString());

                // 使用 with 克隆并修改部分属性
                R01 r02 = r01 with { Age = 20 };
                Assert.Equal("R01 { Name = luotao, Age = 20 }", r02.ToString());
            }
        }

        public record R01(string Name, int Age);
    }
}
