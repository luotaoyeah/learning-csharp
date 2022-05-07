namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._10
{
    namespace _00
    {
        /// <summary>
        /// 3.10. deconstruction
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
                Person person = new() { Name = "luotao", Age = 18 };

                (string? name, int age) = person;
                Assert.Equal("luotao", name);
                Assert.Equal(18, age);
            }
        }

        class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }

            public void Deconstruct(out string? name, out int age)
            {
                name = Name;
                age = Age;
            }

            public void Deconstruct(out string? name)
            {
                name = Name;
            }

            public void Deconstruct(out int age)
            {
                age = Age;
            }
        }
    }
}
