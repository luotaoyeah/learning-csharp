using LT.LIB.BOOK.ICS7._21._01._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._21._01._01
{
    /// <summary>
    /// 21.1.1 a starting example
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
            var myDownloadString = new MyDownloadString(testOutputHelper.WriteLine);
            myDownloadString.DoRun();
        }

        /// <summary>
        /// </summary>
        [Fact]
        public void _02()
        {
            var myDownloadString = new MyDownloadStringAsync(testOutputHelper.WriteLine);
            myDownloadString.DoRun();
        }
    }
}
