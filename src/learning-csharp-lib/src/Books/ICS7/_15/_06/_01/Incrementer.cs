using System;

namespace LuotaoYeah.Lib.Books.ICS7._15._06._01
{
    //----------------------------------------------------------------------------------------------------
    // 如果要在事件触发时传递额外的数据，需要自定义 EventArgs 类，定义需要传递的数据，
    //----------------------------------------------------------------------------------------------------
    public class IncrementerEventArgs : EventArgs
    {
        public int IterationCount { get; set; }
    }

    public class Incrementer
    {
        public event EventHandler<IncrementerEventArgs> CountedADozen;

        public void DoCount()
        {
            for (var i = 0; i < 100; i++)
                if (i % 12 == 0)
                    CountedADozen?.Invoke(
                        this,
                        new IncrementerEventArgs
                        {
                            IterationCount = i
                        }
                    );
        }
    }
}
