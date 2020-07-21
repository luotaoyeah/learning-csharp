namespace Luotao.Test.Books.ICS7._19._05._03
{
    /// <summary>
    /// 19.5.3 using an iterator to create an enumerable
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
            var myClass = new MyClass();

            foreach (var s in myClass)
            {
                testOutputHelper.WriteLine(s);
            }
        }
    }

    class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            return BlankAndWhite().GetEnumerator();
        }

        /// <summary>
        /// iterator 可以返回 IEnumerator, 也可以直接返回 IEnumerable.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<string> BlankAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
