namespace LT.BOOK.ICS7.C03.C0307.C030705
{
    /// <summary>
    /// 3.7.5.2 The Format Specifier
    /// </summary>
    public static class C03070502
    {
        public static string Fn01()
        {
            // {index,alignment:format} 中的 format specifier 用来定义格式,
            // alignment 和 format 之间使用 : 进行分隔,
            // C# 中内置了多种可用的格式

            const int i = 9;
            return $"{i,-5:F2}";
        }
    }
}