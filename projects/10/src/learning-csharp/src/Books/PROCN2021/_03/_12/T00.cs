namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._12
{
    namespace _00
    {
        /// <summary>
        /// 3.12. partial types
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
                C01 c01 = new() { Name = "luotao", Age = 18 };

                Assert.Equal("luotao", c01.Name);

                c01.F01();
            }
        }

        partial class C01
        {
            public int Age { get; set; }

            public void F01()
            {
                F02();
            }

            partial void F02();
        }

        partial class C01
        {
            public string Name { get; set; }
        }
    }
}
