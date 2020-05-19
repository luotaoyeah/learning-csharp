using Luotao.Lib.Books.ICS7._08._14;
using Xunit;

namespace Luotao.Test.Books.ICS7._08._14
{
    /// <summary>
    ///     8.14 extension methods
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myData = new MyData(1, 2, 3);
            Assert.Equal(6, myData.Sum());
            Assert.Equal(2, myData.Average());
        }
    }
}
