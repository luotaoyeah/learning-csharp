namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._08
{
    namespace _02
    {
        /// <summary>
        /// 3.8.2. tuple deconstruction
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var person = ("luotao", 18);

                (string name, int age) = person;
                Assert.Equal("luotao", name);
                Assert.Equal(18, age);

                string name01;
                int age01;
                (name01, age01) = person;
                Assert.Equal("luotao", name01);
                Assert.Equal(18, age01);

                (_, int age02) = person;
                Assert.Equal(18, age02);
            }
        }
    }
}
