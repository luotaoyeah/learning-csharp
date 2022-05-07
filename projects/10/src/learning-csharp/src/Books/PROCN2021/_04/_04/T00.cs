namespace Luotao.LearningCsharp.Test.Books.PROCN2021._04._04
{
    namespace _04
    {
        /// <summary>
        /// 4.4. inheritance with records
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
                var rectangle = new Rectangle(4, 3);
                Assert.Equal(9, rectangle.F01());
            }
        }

        record Shape(int Width, int Height)
        {
            public virtual int F01()
            {
                return 6;
            }
        }

        // record 和 class 不能相互继承
        record Rectangle(int Width, int Height) : Shape(Width, Height)
        {
            public sealed override int F01()
            {
                return 9;
            }
        }
    }
}
