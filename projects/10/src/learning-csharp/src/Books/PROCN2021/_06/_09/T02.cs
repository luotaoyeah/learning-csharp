namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._09
{
    namespace _02
    {
        /// <summary>
        /// 6.9.2. ranges
        /// </summary>
        public class T02
        {
            [Fact]
            public void _01()
            {
                Range range01 = 2..4;

                int[] arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int[] arr02 = arr01[range01];

                Assert.Equal(3, arr02[0]);
                Assert.Equal(4, arr02[1]);
            }

            [Fact]
            public void _02()
            {
                int[] arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int[] arr02 = arr01[^2..^0];

                Assert.Equal(8, arr02[0]);
                Assert.Equal(9, arr02[1]);
            }
        }
    }
}
