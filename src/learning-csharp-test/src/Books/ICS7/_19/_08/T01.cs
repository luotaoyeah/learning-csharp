namespace Luotao.Test.Books.ICS7._19._08
{
    /// <summary>
    /// 19.8 iterators as properties
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
            foreach (string s in spectrum)
            {
                testOutputHelper.WriteLine(s);
            }
        }
    }

    class Spectrum
    {
        /// <summary>
        /// property 也可以作为 iterator block.
        /// </summary>
        private IEnumerator<string> BlackAndWhite
        {
            get
            {
                yield return "black";
                yield return "gray";
                yield return "white";
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite;
        }
    }
}
