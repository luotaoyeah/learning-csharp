namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _05
    {
        /// <summary>
        /// 3.3.5. constructors
        /// </summary>
        public class T05
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T05(ITestOutputHelper testOutputHelper)
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
            private int x;
            private int y;

            public A(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public A(int x) : this(x, 0)
            {
                this.x = x;
            }

            static A()
            {
            }
        }
    }
}
