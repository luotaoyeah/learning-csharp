namespace Luotao.Test.Books.CS10NET6._02._03._11
{
    /// <summary>
    /// 2.3.11. storing multiple values in an array
    /// </summary>
    public class T01
    {
        /// <summary>
        /// array 类型的变量一旦赋值之后, 元素个数就固定了.
        /// </summary>
        [Fact]
        public void _01()
        {
            // 如果没有指定元素的值, 则元素的值为该类型的默认值
            string[] array01 = new string[4];
            Assert.Equal(4, array01.Length);
            Assert.Null(array01[0]);
            Assert.Null(array01[1]);
            Assert.Null(array01[2]);
            Assert.Null(array01[3]);

            string[] array02 = new string[4] { "1", "2", "3", "4" };
            Assert.Equal(4, array02.Length);
            Assert.Equal("1", array02[0]);
            Assert.Equal("2", array02[1]);
            Assert.Equal("3", array02[2]);
            Assert.Equal("4", array02[3]);

            // 由于 target-typed new 语法, 因此省略了类型
            // 由于 array initializer, 因此省略了元素个数
            string[] array03 = new[] { "1", "2", "3", "4" };

            string[] array04 = { "1", "2", "3", "4" };
        }
    }
}
