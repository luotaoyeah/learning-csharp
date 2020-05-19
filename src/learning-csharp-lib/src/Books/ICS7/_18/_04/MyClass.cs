using System.Collections.Generic;

namespace LuotaoYeah.Lib.Books.ICS7._18._04
{
    public class MyClass01
    {
    }

    /// <summary>
    ///     泛型约束（generic constraints）包括5种类型：
    /// </summary>
    /// <typeparam name="T01">必须：某个 class 及其子类</typeparam>
    /// <typeparam name="T02">必须：reference type</typeparam>
    /// <typeparam name="T03">必须：value type</typeparam>
    /// <typeparam name="T04">必须：某个 interface 及其子类</typeparam>
    /// <typeparam name="T05">必须：拥有无参构造函数</typeparam>
    public class MyClass<T01, T02, T03, T04, T05>
        where T01 : MyClass01
        where T02 : class
        where T03 : struct
        where T04 : IEnumerable<T01>
        where T05 : new()
    {
    }
}
