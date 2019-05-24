using System;

namespace LT.BOOK.ICS7.C03.C0307
{
    /// <summary>
    /// 3.7.3. The Format String
    /// </summary>
    public static class C030703
    {
        public static void Fn01()
        {
            // Console.WriteLine() 方法的第一个参数是一个 format string, 
            // 在 format string 里面可以通过 {0} 的形式定义很多占位符(substitution marker),
            // 从第二个参数开始, 每个参数都被称为一个 substitution value,
            // 所有的 substitution value 会依次被替换到对应的占位符所在的位置, 从而组合成最终的结果字符串
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2);

            // 如果 substitution value 的数量过多, 则多余的会被忽略
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2, 9);

            // 如果 substitution value 的数量过少, 编译报错,
            // 如下, 有三个 substitution marker, 但是只有个两个 substitution value
            /*
                        Console.WriteLine("{0} + {1} = {2}", 1, 2);
            */
        }

        public static string Fn02()
        {
            // C# 6.0 引入了一种新的语法形式: string interpolation,
            // 类似于 javascript 中的 template string/template literal

            const int x = 1;
            const int y = 2;

            return $"{x} + {y} = {x + y}";
        }
    }
}