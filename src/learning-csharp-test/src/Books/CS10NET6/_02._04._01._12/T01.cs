namespace Luotao.Test.Books.CS10NET6._02._04._01._12
{
    /// <summary>
    /// 2.4.1.2. formatting using interpolated strings
    /// </summary>
    public class T01
    {
        /// <summary>
        /// </summary>
        [Fact]
        public void _01()
        {
            const string s01 = "luo";
            const string s02 = "tao";
            const string s03 = s01 + " " + s02;
            Assert.Equal("luo tao", s03);

            // C# 10 中, 可以把 interpolated string 赋值给 const string
            const string s04 = $"{s01} {s02}";
            Assert.Equal("luo tao", s04);
        }
    }
}
