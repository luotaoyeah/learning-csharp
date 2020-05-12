namespace LT.LIB.BOOK.ICS7._07._19
{
    /// <summary>
    /// 7.19 partial methods
    /// </summary>
    public partial class C01
    {
        //----------------------------------------------------------------------------------------------------
        // partial method 必须定义在 partial class/struct 中，
        // partial method 包含两个部分：defining declaration 和 implementing declaration，
        //----------------------------------------------------------------------------------------------------
        public static partial int Fn01();
    }

    public partial class C01
    {
        public static partial int Fn01()
        {
            return 6;
        }
    }
}
