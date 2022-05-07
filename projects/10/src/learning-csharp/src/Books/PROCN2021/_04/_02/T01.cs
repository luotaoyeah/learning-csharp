namespace Luotao.LearningCsharp.Test.Books.PROCN2021._04._02
{
    namespace _01
    {
        /// <summary>
        /// 4.2.1. virtual methods
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
                Shape shape = new Rectangle();

                // 多态(polymorphism)时, 调用的是子类 Rectangle.F01() 方法
                Assert.Equal(9, shape.F01());
                Assert.Equal(6, shape.F02());
            }
        }

        class Shape
        {
            public virtual int F01()
            {
                return 6;
            }

            public int F02()
            {
                return 6;
            }
        }

        class Rectangle : Shape
        {
            public override int F01()
            {
                return 9;
            }

            public new int F02()
            {
                return 9;
            }
        }
    }
}
