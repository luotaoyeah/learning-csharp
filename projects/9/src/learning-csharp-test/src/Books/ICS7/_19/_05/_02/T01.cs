namespace Luotao.Test.Books.ICS7._19._05._02
{
    /// <summary>
    /// 19.5.2 using an iterator to create an enumerator
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
            return BlackAndWhite();
        }

        private IEnumerator<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
