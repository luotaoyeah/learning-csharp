using System;

namespace LT.BOOK.ICS7._03._07
{
    /// <summary>
    /// multiple markers and values
    /// </summary>
    public static class C04
    {
        public static void Fn01()
        {
            //----------------------------------------------------------------------------------------------------
            // 在 format string 中， 同一个 substitution marker 可以出现多次，并且顺序是任意的
            //----------------------------------------------------------------------------------------------------
            Console.WriteLine("{1}{0}{1}", 1, 2); // 212
        }
    }
}
