namespace LuotaoYeah.Lib.Books.ICS7._16._07
{
    //----------------------------------------------------------------------------------------------------
    // 如果实现了多个 interface，并且这些 interface 有相同签名的 method，
    // 则 class 只需要提供一个实现就行，
    //----------------------------------------------------------------------------------------------------
    public class MyClass : IMyInterface01, IMyInterface02
    {
        public int F01()
        {
            return 6;
        }
    }
}
