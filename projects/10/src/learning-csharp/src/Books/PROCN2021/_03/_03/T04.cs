namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._03
{
    namespace _04
    {
        /// <summary>
        /// 3.3.4. methods
        /// </summary>
        public class T04
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T04(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                // named arguments
                Assert.Equal(7, A.Fn01(1, z: 4));
            }

            [Fact]
            public void _02()
            {
                int[] arr01 = { 2, 3 };
                Assert.Equal(6, A.Fn02(1, arr01));
                Assert.Equal(6, A.Fn02(1, 2, 3));
            }
        }

        class A
        {
            /// <summary>
            /// optional arguments
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            /// <returns></returns>
            public static int Fn01(int x = 1, int y = 2, int z = 3)
            {
                return x + y + z;
            }

            /// <summary>
            /// variable number of arguments
            /// </summary>
            /// <param name="x"></param>
            /// <param name="nums"></param>
            /// <returns></returns>
            public static int Fn02(int x, params int[] nums)
            {
                int sum = x;

                foreach (int num in nums)
                {
                    sum += num;
                }

                return sum;
            }
        }
    }
}
