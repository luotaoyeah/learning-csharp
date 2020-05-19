namespace LuotaoYeah.Lib.Books.ICS7._14._01
{
    //----------------------------------------------------------------------------------------------------
    // 可以把 delegate 理解成是 C++ 中的 function pointer
    //----------------------------------------------------------------------------------------------------
    public delegate string MyDel();

    public class C01
    {
        private static string PrintLow()
        {
            return "LOW";
        }

        private static string PrintHigh()
        {
            return "HIGH";
        }

        public static MyDel PrintDelegate(int value)
        {
            return value > 50 ? PrintHigh : new MyDel(PrintLow);
        }
    }
}
