namespace Luotao.Test.Books.ICS7._14._01
{
    /// <summary>
    /// 14.1 what is a delegate?
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var random = new Random();

            MyDel del = random.NextInt64(99) < 50 ? new MyDel(PrintLow) : new MyDel(PrintHight);

            del();
        }

        private static string PrintLow()
        {
            return "LOW";
        }

        private static string PrintHight()
        {
            return "HIGH";
        }
    }

    /// <summary>
    /// 定义一个委托类型.
    /// 实际上定义了一个方法签名, 只有匹配该签名的方法才可以存入该委托.
    /// </summary>
    delegate string MyDel();
}
