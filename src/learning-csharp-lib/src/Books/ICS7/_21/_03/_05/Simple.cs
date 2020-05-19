using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Luotao.Lib.Books.ICS7._21._03._05
{
    public class Simple
    {
        private readonly Stopwatch stopwatch = new();

        private readonly Action<string> writeLine;

        public Simple(Action<string> writeLine)
        {
            this.writeLine = writeLine;
        }

        /// <summary>
        ///     <see cref="System.Threading.Tasks.Task.Delay(int)" /> 方法构造一个 <see cref="Task{TResult}" /> 对象,
        ///     在指定的时间之后返回.
        /// </summary>
        /// <returns></returns>
        public async Task ShowDelayAsync()
        {
            writeLine.Invoke("BEFORE");
            stopwatch.Start();

            await Task.Delay(1000);

            writeLine.Invoke($"AFTER: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}
