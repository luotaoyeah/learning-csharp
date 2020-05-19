using System.Threading.Tasks;

namespace LuotaoYeah.Lib.Books.ICS7._21._03
{
    public class DoAsyncStuff
    {
        public static async Task<int> CalculateSumAsync(int i1, int i2)
        {
            var sum = await Task.Run(() => GetSum(i1, i2));
            //----------------------------------------------------------------------------------------------------
            // async method 的返回类型是 Task<int>，但是我们只需要返回 int 类型，
            //----------------------------------------------------------------------------------------------------
            return sum;
        }

        private static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
