namespace Luotao.LearningCsharp.Test.Books.PROCN2021._07._02
{
    namespace _01
    {
        /// <summary>
        /// 7.2.1. declaring delegates
        /// </summary>
        public class T01
        {
            [Fact]
            public void _01()
            {
                int F01(int x, int y)
                {
                    return x + y;
                }

                D01 d01 = new D01(F01);
                Assert.Equal(3, d01(1, 2));

                D01 d02 = F01;
                Assert.Equal(3, d02.Invoke(1, 2));
            }
        }

        public delegate int D01(int x, int y);
    }
}
