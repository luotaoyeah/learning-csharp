namespace LT.LIB.BOOK.ICS7._05._04
{
    /// <summary>
    /// explicit and implicit field initialization
    /// </summary>
    public class C0101
    {
        //----------------------------------------------------------------------------------------------------
        // 显式声明 field 的初始值
        //----------------------------------------------------------------------------------------------------
        public bool B01 = true;

        public double D01 = 0.01d;

        //----------------------------------------------------------------------------------------------------
        // 未显式声明 field 的初始值，使用对应类型的默认值
        //----------------------------------------------------------------------------------------------------
        public int I01; // 0
        public string S01; // null
    }
}