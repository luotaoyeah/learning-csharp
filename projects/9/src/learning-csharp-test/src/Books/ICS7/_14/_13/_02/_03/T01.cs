namespace Luotao.Test.Books.ICS7._14._13._02._03
{
    /// <summary>
    /// 14.13.2.3 the params parameters
    /// </summary>
    public class T01
    {
        /// <summary>
        /// anonymous method 的参数列表中需要省略 params 关键字.
        /// </summary>
        [Fact]
        public void _01()
        {
            MyDel someDel = delegate(int x, int[] y) { return x + y[0]; };
            Assert.Equal(3, someDel(1, 2));
        }
    }

    /// <summary>
    /// delegate 定义中包含 params 关键字.
    /// </summary>
    delegate int MyDel(int x, params int[] y);
}
