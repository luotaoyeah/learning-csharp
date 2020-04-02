namespace LT.BOOK.ICS7.C03.C0307.C030705
{
    /// <summary>
    /// 3.7.5.3 Standard Numeric Format Specifiers
    /// </summary>
    public static class C03070503
    {
        // C# 内置了很多 format specifier

        public static string Fn01()
        {
            // C/c: currency
            return $"{500:C2}";
        }

        public static string Fn02()
        {
            // D/d: decimal
            // decimal 只能用来格式化整数
            return $"{99:D3}";
        }

        public static string Fn03()
        {
            // F/f: fixed-point
            // 保留多少位小数位数
            return $"{3.1415926:F2}";
        }

        public static string Fn04()
        {
            // G/g: general
            // this is the default format specifier
            return $"{99999:G}";
        }

        public static string Fn05()
        {
            // X/x: hexadecimal
            // 将十进制的数字转换为十六进制的数字,
            // X 表示 A-F 使用大写字母,
            // x 表示 a-f 使用小写字母
            return $"{10:X}{10:x}";
        }

        public static string Fn06()
        {
            // N/n: number
            // 使用 , 或者 . 对数字进行分隔, 从小数点开始向左, 每三位一个分隔
            // 默认保留 2 位小数
            return $"{99999:N}";
        }

        public static string Fn07()
        {
            // P/p: percent
            // 格式化为百分比
            return $"{0.25:P2}";
        }

        public static string Fn08()
        {
            // E/e: scientific
            // 科学计数法
            // E 表示使用大写的 E
            // e 表示使用小写的 e
            return $"{12.3456789:E2}";
        }
    }
}
