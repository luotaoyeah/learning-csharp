using Luotao.Lib.Books.ICS7._14._13._03._01;

namespace Luotao.Test.Books.ICS7._14._13._03._01
{
    /// <summary>
    ///     14.13.3.1 outer variables
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
            MyDel GetMyDel()
            {
                const int x = 6;

                MyDel myDel = delegate
                {
                    //----------------------------------------------------------------------------------------------------
                    // 在 anonymous method 中可以访问 outer scope 中的 variable，并且会 capture 这个 variable，
                    //----------------------------------------------------------------------------------------------------
                    testOutputHelper.WriteLine($"{x}");
                    return x;
                };

                return myDel;
            }

            //----------------------------------------------------------------------------------------------------
            // 此时 GetMyDel() 执行完毕，x 是它里面的 local variable，因此也被销毁，
            // 但是返回的 delegate 中因为 capture 了这个 x，因此它依然可以访问 x 变量，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, GetMyDel()());
        }
    }
}
