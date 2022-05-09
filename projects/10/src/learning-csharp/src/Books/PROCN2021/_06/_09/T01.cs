namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._09
{
    namespace _01
    {
        /// <summary>
        /// 6.9.1. indices and the hat operator
        /// </summary>
        public class T01
        {
            [Fact]
            public void _01()
            {
                int[] arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Assert.Equal(9, arr01[arr01.Length - 1]);

                // 索引从右往左, 从 1 开始
                Assert.Equal(9, arr01[^1]);
            }
        }
    }
}
