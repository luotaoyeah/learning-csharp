using System.Collections;

namespace Luotao.Test.Books.CS10NET6._03._03._04
{
    /// <summary>
    /// 3.3.4 looping with the foreach statement
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// foreach...in 遍历一个集合.
        /// </summary>
        [Fact]
        public void _01()
        {
            string[] names = { "A", "B", "C" };

            foreach (string name in names)
            {
                testOutputHelper.WriteLine(name);
            }
        }

        /// <summary>
        /// foreach 实际上是下面这段代码的语法糖.
        /// </summary>
        [Fact]
        public void _02()
        {
            string[] names = { "A", "B", "C" };

            IEnumerator enumerator = names.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current is string current)
                {
                    testOutputHelper.WriteLine(current);
                }
            }
        }
    }
}
