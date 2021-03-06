using System;
using System.Threading.Tasks;

namespace Luotao.Lib.Books.ICS7._21._03
{
    public class DoAsyncStuff03
    {
        private readonly Action<string> WriteLine;

        public DoAsyncStuff03(Action<string> writeLine)
        {
            WriteLine = writeLine;
        }

        /// <summary>
        ///     async method 的返回类型为 void 时，方法里面不需要返回数据，
        ///     这种 async method 无法跟 calling method 进行交互，
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public async void CalculateSumAsync(int i1, int i2)
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
