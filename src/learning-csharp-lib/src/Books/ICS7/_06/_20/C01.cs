using System.Linq;

namespace LuotaoYeah.Lib.Books.ICS7._06._20
{
    /// <summary>
    ///     6.20 optional parameters
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 如果参数声明了默认值，则它是一个 optional parameter，
        // 所有的 optional parameter 必须位于所有的 non-optional parameter 后面，
        // params parameter 必须位于 optional parameter 后面，
        //----------------------------------------------------------------------------------------------------

        public static int Fn01(int x, int y = 2, params int[] arr)
        {
            return x + y + arr.Sum();
        }

        public static int Fn02(int x = 1, int y = 2, int z = 3)
        {
            return x + y;
        }
    }
}
