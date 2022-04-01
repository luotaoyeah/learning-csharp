namespace Luotao.Test.Books.ICS7._14._13._02._02
{
    /// <summary>
    /// 14.13.2.2 parameters
    /// </summary>
    public class T01
    {
        /// <summary>
        /// 如果:
        ///   1. 没有 out 参数
        ///   2. 方法体中没有使用任何参数
        /// 则参数列表可以省略.
        /// </summary>
        [Fact]
        public void _01()
        {
            Func<int, int> del01 = delegate { return 6; };
            Assert.Equal(6, del01(0));
        }
    }
}
