namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._08
{
    namespace _01
    {
        /// <summary>
        /// 6.8.1. creating slices
        /// </summary>
        public class T01
        {
            [Fact]
            public void _01()
            {
                int[] arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Span<int> span01 = new Span<int>(arr01, start: 2, length: 5);

                Assert.Equal(3, span01[0]);
                Assert.Equal(4, span01[1]);
                Assert.Equal(5, span01[2]);
                Assert.Equal(6, span01[3]);
                Assert.Equal(7, span01[4]);

                Span<int> span02 = span01.Slice(start: 2, length: 2);
                Assert.Equal(5, span02[0]);
                Assert.Equal(6, span02[1]);
            }
        }
    }
}
