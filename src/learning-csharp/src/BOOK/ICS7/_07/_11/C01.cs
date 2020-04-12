using System;

namespace LT.BOOK.ICS7._07._11
{
    /// <summary>
    /// 7.11 instance constructors
    /// </summary>
    public class C01
    {
        public DateTime time;

        //----------------------------------------------------------------------------------------------------
        // constructor 跟类同名，没有返回类型，
        //----------------------------------------------------------------------------------------------------
        public C01()
        {
            time = DateTime.Now;
        }
    }
}
