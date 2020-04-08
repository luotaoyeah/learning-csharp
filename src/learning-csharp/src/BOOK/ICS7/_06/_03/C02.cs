namespace LT.BOOK.ICS7._06._03
{
    /// <summary>
    /// 6.3.2 local variables inside nested blocks
    /// </summary>
    public class C02
    {
        public static int Fn01()
        {
            var i01 = 6;

            {
                var i02 = i01 + 8;
                //----------------------------------------------------------------------------------------------------
                // inner scope 中的变量不能跟 outer scope 中的变量同名
                //----------------------------------------------------------------------------------------------------
            }

            return i01;
        }
    }
}
