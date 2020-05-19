namespace LuotaoYeah.Lib.Books.ICS7._08._02
{
    /// <summary>
    ///     8.2 accessing the inherited members
    /// </summary>
    public class C01
    {
        public int I01 = 1;

        public int Fn01()
        {
            return 1;
        }
    }

    public class C02 : C01
    {
        public int I02 = 2;

        public int Fn02()
        {
            //----------------------------------------------------------------------------------------------------
            // 正常访问继承来的 field 和 method
            //----------------------------------------------------------------------------------------------------
            return I01 + Fn01() + I02;
        }
    }
}
