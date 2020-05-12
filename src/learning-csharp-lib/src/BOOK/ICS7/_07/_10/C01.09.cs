namespace LT.LIB.BOOK.ICS7._07._10
{
    /// <summary>
    /// 7.10.9 automatically implemented properties: auto-properties
    /// </summary>
    public class C0109
    {
        //----------------------------------------------------------------------------------------------------
        // 由于 property 通常都会对应一个 field 一起使用，C# 提供了一种语法糖称之为 auto-property，
        // 它可以帮我们隐式地创建对应的 field，
        // 它的 get/set 不能包含 body，只能是简单的读写对应的 field 的值，
        //----------------------------------------------------------------------------------------------------

        public int P01 { get; set; }
    }
}
