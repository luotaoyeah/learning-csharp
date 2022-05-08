namespace Luotao.LearningCsharp.Test.Books.PROCN2021._06._05
{
    namespace _00
    {
        /// <summary>
        /// 6.5. Array class
        /// </summary>
        public class T00
        {
            [Fact]
            public void _01()
            {
                Array arr01 = Array.CreateInstance(typeof(int), 3);

                arr01.SetValue(1, 0);
                arr01.SetValue(2, 1);
                arr01.SetValue(3, 2);

                Assert.Equal(1, arr01.GetValue(0));
            }

            [Fact]
            public void _02()
            {
                int[] arr01 = Array.Empty<int>();
                Assert.Equal(0, arr01.Length);
            }
        }
    }
}
