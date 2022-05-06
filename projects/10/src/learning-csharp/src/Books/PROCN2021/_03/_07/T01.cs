namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._07
{
    namespace _01
    {
        /// <summary>
        /// 3.7.1. ref
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
                void F01(int x)
                {
                    x = 8;
                }

                int a = 6;
                Assert.Equal(6, a);

                F01(a);
                Assert.Equal(6, a);
            }

            [Fact]
            public void _02()
            {
                void F01(ref int x)
                {
                    x = 8;
                }

                int a = 6;
                Assert.Equal(6, a);

                F01(ref a);
                Assert.Equal(8, a);
            }

            [Fact]
            public void _03()
            {
                void F01(C01 c)
                {
                    c.X = 8;

                    c = new C01() { X = 9 };
                }

                C01 c01 = new C01() { X = 6 };
                Assert.Equal(6, c01.X);

                F01(c01);
                Assert.Equal(8, c01.X);
            }

            [Fact]
            public void _04()
            {
                void F01(ref C01 c)
                {
                    c.X = 8;

                    c = new C01() { X = 9 };
                }

                C01 c01 = new() { X = 6 };
                Assert.Equal(6, c01.X);

                F01(ref c01);
                Assert.Equal(9, c01.X);
            }
        }

        class C01
        {
            public int X { get; set; }
        }
    }
}
