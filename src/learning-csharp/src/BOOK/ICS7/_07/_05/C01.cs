namespace LT.BOOK.ICS7._07._05
{
    /// <summary>
    /// 7.5 accessing static members from outside the class
    /// </summary>
    public class C01
    {
        public static int I01 = 6;

        private static void Fn02()
        {
        }

        public void Fn01()
        {
            //----------------------------------------------------------------------------------------------------
            // instance method 中可以直接访问 static member
            //----------------------------------------------------------------------------------------------------
            I01 = 8;
            Fn02();
        }
    }
}
