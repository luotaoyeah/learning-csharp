using System;
using System.Threading.Tasks;

namespace Luotao.Lib.Books.ICS7._21._03._02._01
{
    public class MyClass
    {
        private readonly Action<string> writeLine;

        public MyClass(Action<string> writeLine)
        {
            this.writeLine = writeLine;
        }

        /// <summary>
        ///     await expression 中抛出的异常可以被 try/catch 捕获
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task BadAsync()
        {
            try
            {
                await Task.Run(() => { throw new Exception("FOO"); });
            }
            catch (Exception e)
            {
                writeLine(e.Message);
            }
        }
    }
}
