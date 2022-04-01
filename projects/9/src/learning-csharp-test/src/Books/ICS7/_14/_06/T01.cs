namespace Luotao.Test.Books.ICS7._14._06
{
    /// <summary>
    /// 14.6 combining delegates
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        private void F01()
        {
            testOutputHelper.WriteLine("01");
        }

        private void F02()
        {
            testOutputHelper.WriteLine("02");
        }

        /// <summary>
        /// delegate is immutable.
        /// 两个 delegate 相加：新建一个 delegate, 它的 invocation list 包含两个 delegate 的 invocation list 中的所有方法.
        /// </summary>
        [Fact]
        public void _01()
        {
            var del01 = new MyDel(F01);
            var del02 = new MyDel(F02);
            var del03 = del01 + del02;
            del03();
        }
    }

    delegate void MyDel();
}
