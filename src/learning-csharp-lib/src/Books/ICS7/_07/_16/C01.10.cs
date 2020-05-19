namespace LuotaoYeah.Lib.Books.ICS7._07._16
{
    /// <summary>
    ///     7.16.10 indexer overloading
    /// </summary>
    public class C0110
    {
        //----------------------------------------------------------------------------------------------------
        // 通过定义不同的参数列表，来实现 indexer 的重载
        //----------------------------------------------------------------------------------------------------

        public int this[int index] => 6;

        public int this[int x, int y] => 8;
    }
}
