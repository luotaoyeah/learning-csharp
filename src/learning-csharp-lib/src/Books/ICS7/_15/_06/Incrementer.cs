using System;

namespace Luotao.Lib.Books.ICS7._15._06
{
    public class Incrementer
    {
        //----------------------------------------------------------------------------------------------------
        // 系统内置了一个 delegate 叫做 EventHandler，
        //----------------------------------------------------------------------------------------------------
        public event EventHandler CountedADozen;

        public void DoCount()
        {
            for (var i = 0; i < 100; i++)
                if (i % 12 == 0)
                    CountedADozen?.Invoke(this, EventArgs.Empty);
        }
    }
}
