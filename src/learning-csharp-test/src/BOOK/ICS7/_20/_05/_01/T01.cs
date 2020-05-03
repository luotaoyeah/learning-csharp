using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._20._05._01
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


        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };

            var query01 =
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

            //----------------------------------------------------------------------------------------------------
            // from  后面的 iteration variable 可以指定类型，
            // in    后面的表示数据源，必须是一个 IEnumerable 对象，
            // where 后面是一个 bool 表达式，
            //----------------------------------------------------------------------------------------------------
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
