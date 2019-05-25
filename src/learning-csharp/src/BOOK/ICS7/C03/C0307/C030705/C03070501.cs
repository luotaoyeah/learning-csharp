namespace LT.BOOK.ICS7.C03.C0307.C030705
{
    /// <summary>
    /// 3.7.5.1 The Alignment Specifier
    /// </summary>
    public static class C03070501
    {
        public static string Fn01()
        {
            // 在 format string 中({index,alignment:format}),
            // alignment 用来设置 alignment 方式, 它的值为一个正数或者负数, 表示所占的宽度
            // 正数表示右对齐, 负数表示左对齐

            const int i = 9;
            return $"{i,5}";
        }

        public static string Fn02()
        {
            const int i = 9;
            return $"{i,-5}";
        }

        public static string Fn03()
        {
            // 如果实际的宽度超过了 alignment 指定的宽度, 则 alignment 会被忽略

            const int i = 999999;
            return $"{i,5}";
        }
    }
}