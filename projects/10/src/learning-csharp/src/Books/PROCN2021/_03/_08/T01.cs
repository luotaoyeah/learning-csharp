namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._08
{
    namespace _01
    {
        /// <summary>
        /// 3.8.1. declaring and initializing tuples
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
                // 使用 Item1/Item2 访问 tuple 的各个成员
                (int, string) person01 = (18, "luotao");

                Assert.Equal(18, person01.Item1);
                Assert.Equal("luotao", person01.Item2);
            }

            [Fact]
            public void _02()
            {
                // 指定成员的名称
                (int Age, string Name) person = (18, "luotao");

                Assert.Equal(18, person.Item1);
                Assert.Equal(18, person.Age);
                Assert.Equal("luotao", person.Item2);
                Assert.Equal("luotao", person.Name);
            }

            [Fact]
            public void _03()
            {
                var person01 = (18, "luotao");

                Assert.Equal(18, person01.Item1);
                Assert.Equal("luotao", person01.Item2);

                var person02 = (Age: 18, Name: "luotao");

                Assert.Equal(18, person02.Age);
                Assert.Equal("luotao", person02.Name);
            }
        }
    }
}
