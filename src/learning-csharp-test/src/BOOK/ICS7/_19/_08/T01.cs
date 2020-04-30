using LT.BOOK.ICS7._19._08;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._19._08
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
}
