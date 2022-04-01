namespace Luotao.Test.Books.ICS7._06._09
{
    /// <summary>
    ///     6.9 local functions
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(10, C01.F01(3, 4));
        }
    }

    public class C01
    {
        /// <summary>
        ///     function 里面可以定义 function, 称之为 local function, 类似于 local variable.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int F01(int x, int y)
        {
            return InnerFn(1, 2);

            //----------------------------------------------------------------------------------------------------
            // local function 可以定义在 return 语句之后,
            // local function 只能在 outer function 中使用.
            //----------------------------------------------------------------------------------------------------
            int InnerFn(int a, int b)
            {
                return a + b + x + y;
            }
        }
    }
}
