using System;

namespace LT.BOOK.ICS7.C03.C0307.C030705
{
    /// <summary>
    /// 3.7.5. Formatting Numeric Strings
    /// </summary>
    public static class C030705
    {
        public static string Fn01()
        {
            // format string 中的 substitution marker 可以包含三个部分: {index,alignment:format}
            // 其中, alignment 和 format 是可选的
            // 当 index 对应的 substitution value 是一个 number 时, 
            // format 用来对这个 number 进行格式化输出

            const int num = 500;
            Console.WriteLine("{0:C}", num);
            return $"{num:C}";
        }
    }
}
