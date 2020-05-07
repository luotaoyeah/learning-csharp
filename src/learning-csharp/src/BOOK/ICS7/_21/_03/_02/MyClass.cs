using System;
using System.Threading;
using System.Threading.Tasks;

namespace LT.BOOK.ICS7._21._03._02
{
    public class MyClass
    {
        private readonly Action<string> writeLine;

        public MyClass(Action<string> writeLine)
        {
            this.writeLine = writeLine;
        }

        public async Task RunAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            await Task.Run(() => CycleMethod(cancellationToken), cancellationToken);
        }

        private void CycleMethod(CancellationToken cancellationToken)
        {
            int max = 5;
            for (int i = 0; i < max; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                Thread.Sleep(1000);

                writeLine.Invoke((i + 1).ToString());
            }
        }
    }
}
