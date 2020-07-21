namespace Luotao.Test.Books.ICS7._19._03
{
    /// <summary>
    /// 19.3 the IEnumerable interface
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
            var spectrum = new Spectrum();
            foreach (string o in spectrum)
            {
                testOutputHelper.WriteLine(o);
            }
        }
    }
}
