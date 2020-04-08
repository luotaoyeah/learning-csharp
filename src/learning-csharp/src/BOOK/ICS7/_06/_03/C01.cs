namespace LT.BOOK.ICS7._06._03
{
    /// <summary>
    /// 6.3.1 type inference and the var keyword
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 使用 var 作为变量类型，让 compiler 帮我们推断类型，
        // 使用 var 时变量必须初始化，
        // var 只能用于 local variable，不能用于 class field
        //----------------------------------------------------------------------------------------------------
        public static int Fn01()
        {
            var i01 = 6;
            return i01;
        }
    }
}
