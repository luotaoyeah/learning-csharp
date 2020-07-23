namespace Luotao.Test.Books.ICS7._20._05._04._01
{
    /// <summary>
    /// 20.5.4.1 the from clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 一个查询可以包含多个 from, 其中第一个 from 是必须的.
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 6, 7, 8, 9 };

            var query =
                from a in arr01
                from b in arr02
                where a % 2 == 0 && b % 2 == 1
                select new { a, b, sum = a + b };

            foreach (var i in query)
            {
                testOutputHelper.WriteLine($"{i.a} + {i.b} = {i.sum}");
            }
        }
    }
}
