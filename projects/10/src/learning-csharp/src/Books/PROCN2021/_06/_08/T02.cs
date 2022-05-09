namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._08
{
    namespace _02
    {
        /// <summary>
        /// 6.8.2. changing values using spans
        /// </summary>
        public class T02
        {
            [Fact]
            public void _01()
            {
                int[] arr01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Span<int> span01 = new Span<int>(arr01, 2, 2);
                Assert.Equal(3, span01[0]);
                Assert.Equal(4, span01[1]);

                span01.Clear();
                Assert.Equal(0, span01[0]);
                Assert.Equal(0, span01[1]);

                span01.Fill(6);
                Assert.Equal(6, span01[0]);
                Assert.Equal(6, span01[1]);
            }
        }
    }
}
