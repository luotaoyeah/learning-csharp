namespace Luotao.Test.Books.ICS7._20._05._04._02
{
    /// <summary>
    /// 20.5.4.2 the let clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// let 用来定义一个临时变量, 这个临时变量可以被其他子句使用.
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 6, 7, 8, 9 };

            var query =
                from a in arr01
                from b in arr02
                let sum = a + b
                where sum == 12
                select new { a, b, sum };

            foreach (var i in query)
            {
                testOutputHelper.WriteLine($"{i.a} + {i.b} = {i.sum}");
            }
        }
    }
}
