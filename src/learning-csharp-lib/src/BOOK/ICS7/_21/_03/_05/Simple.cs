using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LT.LIB.BOOK.ICS7._21._03._05
{
    public class Simple
    {
        Stopwatch stopwatch = new Stopwatch();

        private Action<string> writeLine;

        public Simple(Action<string> writeLine)
        {
            this.writeLine = writeLine;
        }

        /// <summary>
        /// <see cref="System.Threading.Tasks.Task.Delay(int)"/> 方法构造一个 <see cref="Task{TResult}"/> 对象,
        /// 在指定的时间之后返回.
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
