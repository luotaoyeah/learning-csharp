namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _03
    {
        /// <summary>
        /// 3.3.3. properties
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
            }
        }

        class A
        {
            private int age;

            public int Age
            {
                get => age;
                set => age = value;
            }

            public string? Name { get; set; } = "luotao";

            public int X01
            {
                get => 0;
            }

            // expression-bodied property
            public int X02 => 0;
        }
    }
}
