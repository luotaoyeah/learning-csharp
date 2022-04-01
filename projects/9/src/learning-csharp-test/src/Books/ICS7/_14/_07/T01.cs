namespace Luotao.Test.Books.ICS7._14._07
{
    /// <summary>
    /// 14.7 adding methods to delegates
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
        /// 使用 += 往 delegate 添加新的 method, 同一个 method 可以被添加多次.
        /// 因为 delegate is immutable, 因此每次都会创建一个新的 delegate 对象.
        /// </summary>
        [Fact]
        public void _01()
        {
            var del01 = new MyDel(F01);
            del01 += F02;
            del01 += F01;

            del01();
        }
    }

    delegate void MyDel();
}
