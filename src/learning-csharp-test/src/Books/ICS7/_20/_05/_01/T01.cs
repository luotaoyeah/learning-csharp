namespace Luotao.Test.Books.ICS7._20._05._01
{
    /// <summary>
    /// 20.5.1 the from clause
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// from 用来指定数据源, 数据源必须是 IEnumerable.
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };

            IEnumerable<int> query01 =
                from i in arr01
                where i % 2 == 1
                select i;

            foreach (var i in query01)
            {
                testOutputHelper.WriteLine(i.ToString());
            }
        }

        [Fact]
        public void _02()
        {
            int[] arr01 = { 1, 2, 3 };

            // from 后面的迭代变量可以指定类型, 但是一般省略, 编译器可以推断
            var query01 =
                from int i in arr01
                where i % 2 == 1
                select i;

            foreach (var i in query01)
            {
                testOutputHelper.WriteLine(i.ToString());
            }
        }
    }
}
