using Luotao.LearningCsharp.Test.Books.PROCN2021._09._00;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._09._02
{
    namespace _02
    {
        /// <summary>
        /// 9.2.2. filter with index
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                // 下面的 Where() 方法无法转换为等价的查询表达式
                IEnumerable<int> query = items.Where((i, index) => index % 2 == 0);

                foreach (int i in query)
                {
                    testOutputHelper.WriteLine(i.ToString());
                }
            }
        }
    }
}
