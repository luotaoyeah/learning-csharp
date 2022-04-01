namespace Luotao.Test.Books.ICS7._19._05._01
{
    /// <summary>
    /// 19.5.1 iterator blocks
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            IEnumerator<string> enumerator = BlackAndWhite();

            Assert.True(enumerator.MoveNext());
            Assert.Equal("black", enumerator.Current);

            Assert.True(enumerator.MoveNext());
            Assert.Equal("gray", enumerator.Current);

            Assert.True(enumerator.MoveNext());
            Assert.Equal("white", enumerator.Current);

            Assert.False(enumerator.MoveNext());
        }

        /// <summary>
        /// iterator 是 IEnumerator / IEnumerable 的语法糖, 编译器根据 iterator 帮我们生成对应的 IEnumerator / IEnumerable 类.
        /// </summary>
        /// <returns></returns>
        private IEnumerator<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
