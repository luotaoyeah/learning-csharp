namespace Luotao.Lib.Books.ICS7._16._09
{
    /// <summary>
    ///     如果父类中的某个 method 刚好满足 interface 中某个 method 的实现，
    ///     则子类可以不用再实现这个 method，直接从父类继承即可，
    /// </summary>
    public class MyClass : MyBaseClass, IMyInterface01
    {
    }
}
