using System;

namespace LT.LIB.BOOK.ICS7._07._10
{
    /// <summary>
    /// 7.10.6 read-only and write-only properties
    /// </summary>
    public class C0106
    {
        //----------------------------------------------------------------------------------------------------
        // 如果只有 get，则它是一个 read-only property
        //----------------------------------------------------------------------------------------------------
        public int P01
        {
            get { return 6; }
        }

        //----------------------------------------------------------------------------------------------------
        // 如果只有 set，则它是一个 write-only property
        //----------------------------------------------------------------------------------------------------
        public int P02
        {
            set { Console.Write($"{value}"); }
        }
    }
}