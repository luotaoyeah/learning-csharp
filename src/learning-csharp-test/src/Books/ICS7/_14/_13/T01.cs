namespace Luotao.Test.Books.ICS7._14._13
{
    /// <summary>
    /// 14.13 anonymous methods
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// delegate 中的方法可以是匿名方法(anonymous method).
        /// </summary>
        [Fact]
        public void _01()
        {
            // 使用 delegate 关键字声明一个匿名方法, 包含参数列表和方法体, 但是没有方法名
            Func<int, int> del01 = delegate(int x) { return x + 20; };
            Assert.Equal(25, del01(5));

            del01 += delegate(int i) { return i * 2; };
            Assert.Equal(10, del01(5));
        }
    }
}
