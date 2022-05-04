namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._06
{
    /// <summary>
    /// 2.6.6. ranges with strings
    /// </summary>
    public class _06
    {
        [Fact]
        public void _01()
        {
            string s = "The quick brown fox jumped over the lazy dogs down 1234567890 times";

            // 通过 index 获取单个字符
            Assert.Equal(s[0], 'T');

            // 通过 range 获取子字符串,
            // 左闭右开,
            Assert.Equal(s[0..3], "The");
            Assert.Equal(s[..3], "The");
            Assert.Equal(s[4..9], "quick");

            // 从右往左
            Assert.Equal(s[^5..^0], "times");
        }
    }
}
