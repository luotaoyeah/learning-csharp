namespace Luotao.Test.Books.ICS7._14._13._03._01
{
    /// <summary>
    /// 14.13.3.1 outer variables
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            // local function
            MyDel GetMyDel()
            {
                const int x = 6;

                MyDel myDel = delegate
                {
                    // 在匿名方法中访问并捕获外部变量
                    testOutputHelper.WriteLine($"{x}");
                    return x;
                };

                return myDel;
            }

            // 此时 GetMyDel() 执行完毕, x 是它里面的 local variable, 因此也被销毁,
            // 但是返回的 delegate 中因为 capture 了这个 x, 因此它依然可以访问 x,
            MyDel del01 = GetMyDel();
            Assert.Equal(6, del01());
        }
    }

    delegate int MyDel();
}
