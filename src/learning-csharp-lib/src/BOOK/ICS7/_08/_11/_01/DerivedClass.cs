namespace LT.LIB.BOOK.ICS7._08._11._01
{
    //----------------------------------------------------------------------------------------------------
    // 父类是 abstract class，子类不是 abstract class，则子类必须实现父类所有的 abstract method，
    //----------------------------------------------------------------------------------------------------
    public class DerivedClass : AbClass
    {
        public override string IdentifyDerived()
        {
            return "I am DerivedClass";
        }
    }
}
