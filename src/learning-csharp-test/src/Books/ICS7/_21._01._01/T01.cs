namespace Luotao.Test.Books.ICS7._21._01._01
{
    /// <summary>
    /// 21.1.1 a starting example
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myDownloadString = new MyDownloadString();
            myDownloadString.DoRun();
        }

        [Fact]
        public void _02()
        {
            var myDownloadString = new MyDownloadStringAsync();
            myDownloadString.DoRun();
        }
    }
}
