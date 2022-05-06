namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._05
{
    namespace _00
    {
        /// <summary>
        /// 3.5. structs
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
            }
        }

        interface I01
        {
        }

        struct S01
        {
        }

        // struct 可以实现 interface, 但是不能继承其他 struct
        struct S02 : I01
        {
            public int Age { get; set; }

            // struct 不能自己定义无参的 constructor
            public S02(int age) : this()
            {
                Age = age;
            }
        }
    }
}
