using Luotao.Lib.Books.ICS7._21._03._03;

namespace Luotao.Test.Books.ICS7._21._03._03
{
    /// <summary>
    ///     21.3.3 waiting synchronously for tasks in the calling method
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
            MyDownloadString myDownloadString =
                new(testOutputHelper.WriteLine);
            myDownloadString.DoRun();
        }
    }
}
