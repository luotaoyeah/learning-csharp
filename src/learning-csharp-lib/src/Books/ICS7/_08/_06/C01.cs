namespace Luotao.Lib.Books.ICS7._08._06
{
    /// <summary>
    ///     8.6 using references to a base class
    /// </summary>
    public class C01
    {
        public int I01 = 6;
    }

    public class C02 : C01
    {
        public new int I01 = 8;
        public int I02 = 2;
    }
}
