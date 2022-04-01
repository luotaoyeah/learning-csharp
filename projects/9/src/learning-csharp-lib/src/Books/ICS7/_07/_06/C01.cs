namespace Luotao.Lib.Books.ICS7._07._06
{
    /// <summary>
    ///     7.6 static function members
    /// </summary>
    public class C01
    {
        public static int I01 = 6;
        public int I02 = 6;

        //----------------------------------------------------------------------------------------------------
        // static method 中只能访问 static member
        //----------------------------------------------------------------------------------------------------
        public static int Fn01()
        {
            I01 = 8;
            return I01;
        }
    }
}
