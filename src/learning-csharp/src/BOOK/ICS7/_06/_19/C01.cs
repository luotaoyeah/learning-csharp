using System.Linq;

namespace LT.BOOK.ICS7._06._19
{
    /// <summary>
    /// 6.19 named parameters
    /// </summary>
    public class C01
    {
        public static int Fn01(int x, int y, int z, params int[] arr)
        {
            return x + y + z + arr.Sum();
        }
    }
}
