using System;
using System.Threading.Tasks;

namespace LuotaoYeah.Lib.Books.ICS7._21._03
{
    public class DoAsyncStuff02
    {
        private readonly Action<string> WriteLine;

        public DoAsyncStuff02(Action<string> writeLine)
        {
            WriteLine = writeLine;
        }

        /// <summary>
        ///     async method 的返回类型为 Task 时，方法里面不需要返回数据，
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public async Task CalculateSumAsync(int i1, int i2)
        {
            var value = await Task.Run(() => GetSum(i1, i2));
            WriteLine($"Value: {value}");
        }

        private static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
