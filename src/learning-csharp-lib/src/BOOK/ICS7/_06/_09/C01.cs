namespace LT.LIB.BOOK.ICS7._06._09
{
    /// <summary>
    /// 6.9 local functions
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // function 里面可以定义 function，称之为 local function
        //----------------------------------------------------------------------------------------------------
        public static int Fn01(int x, int y)
        {
            int InnerFn(int a, int b)
            {
                return a + b + x + y;
            }

            return InnerFn(x, y);
        }
    }
}
