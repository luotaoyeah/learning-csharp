using Xunit;

namespace Luotao.Test.Books.ICS7._03._07
{
    public class C0501
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // alignment 表示占位宽度，宽度不足时用空格补齐，宽度超过时会忽略 alignment，
            // 正数表示右对齐，负数表示左对齐，
            //----------------------------------------------------------------------------------------------------

            Assert.Equal("  6", $"{6,+3}");
            Assert.Equal("6  ", $"{6,-3}");
        }
    }
}