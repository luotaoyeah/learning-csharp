namespace Luotao.Test.Books.ICS7._20._04
{
    /// <summary>
    /// 20.4 query variables
    /// </summary>
    public class T01
    {
        /// <summary>
        /// LINQ 查询可以返回两种类型的数据:
        ///   1. IEnumerable 可遍历的集合
        ///   2. 单值 (Count/Max/Min/Sum...)
        /// </summary>
        [Fact]
        public void _01()
        {
            List<int> arr01 = new List<int>() { 1, 2, 3, };

            // query01 是一个 query variable
            IEnumerable<int> query01 =
                from n in arr01
                select n;

            // count 也是一个 query variable
            int count = (
                from i in arr01
                select i
            ).Count();

            arr01.Add(4);
            arr01.Add(5);

            // 如果返回 IEnumerable, 则只有在真正使用时, 才会去执行查询操作,
            // 并且每使用一次就会查询一次
            Assert.Equal(5, query01.Count());

            // 如果返回单值, 则会立即执行
            Assert.Equal(3, count);
        }
    }
}
