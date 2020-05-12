namespace LT.LIB.BOOK.ICS7._03._07
{
    /// <summary>
    /// formatting numeric strings
    /// </summary>
    public static class C05
    {
        public static string F01()
        {
            //----------------------------------------------------------------------------------------------------
            // substitution marker 中可以包含三个部分: {index/variable,alignment:format}
            //   alignment 表示展位宽度以及左右对齐, 正数右对齐, 负数左对齐, 可以省略,
            //   format    表示格式方式
            //----------------------------------------------------------------------------------------------------

            return $"{500,10:C}";
        }
    }
}
