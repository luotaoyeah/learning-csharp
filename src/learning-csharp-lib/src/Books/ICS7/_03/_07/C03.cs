using System;

namespace Luotao.Lib.Books.ICS7._03._07
{
    /// <summary>
    ///     the format string
    /// </summary>
    public static class C03
    {
        public static void Fn01()
        {
            //----------------------------------------------------------------------------------------------------
            // 输出格式化的字符串，
            // 其中的 {n} 叫做 substitution marker，从 0 开始，
            // 后面的每个参数，依次替换前面的 substitution marker，多余的参数会被忽略，
            //----------------------------------------------------------------------------------------------------
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 3, 4);
        }

        public static string Fn02()
        {
            //----------------------------------------------------------------------------------------------------
            // string interpolation 类似于 js 中的 template string
            //----------------------------------------------------------------------------------------------------

            const int x = 1;
            const int y = 2;

            return $"{x} + {y} = {x + y}";
        }
    }
}
