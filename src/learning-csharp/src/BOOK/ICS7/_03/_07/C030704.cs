using System;

namespace LT.BOOK.ICS7.C03.C0307
{
    /// <summary>
    /// 3.7.4. Multiple Markers and Values
    /// </summary>
    public static class C030704
    {
        public static void Fn01()
        {
            // 在 format string 中, 同一个 substitution marker 可以出现多次,
            // 并且 substitution marker 的顺序是任意的
            Console.WriteLine("{1}{0}{1}", "A", "B"); // BAB
        }
    }
}
