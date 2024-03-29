namespace Luotao.Test.Books.ICS7._20._05._04._03
{
    /// <summary>
    /// 20.5.4.3 the where clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 在一个 from...let...where 块中, 可以包含多个 where, 表示这些条件必须都满足.
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6 };
            int[] arr02 = { 6, 7, 8, 9 };

            var query01 =
                from a in arr01
                from b in arr02
                let sum = a + b
                where sum == 12
                where a % 2 == 1
                select new { a, b, sum };

            foreach (var o in query01)
            {
                testOutputHelper.WriteLine($"{o.a} + {o.b} = {o.sum}");
            }

            testOutputHelper.WriteLine("----------------------------");

            var query02 =
                from a in arr01
                from b in arr02
                let sum = a + b
                where sum == 12 && a % 2 == 1
                select new { a, b, sum };

            foreach (var o in query02)
            {
                testOutputHelper.WriteLine($"{o.a} + {o.b} = {o.sum}");
            }
        }
    }
}
