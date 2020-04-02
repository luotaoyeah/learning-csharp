namespace LT.BOOK.ICS7.C05.C0507
{
    /// <summary>
    /// 5.7. Instance Members
    /// </summary>
    public class C0507
    {
        /*
         * class 中的 member 包括 static member 和 instance member,
         * static member 使用关键字 static 来声明,
         *     static member 是关联到 class 上的, 所有 instance 共享一份,
         * instance member 是关联到 class instance 上的, 每个 instance 各有一份
         */
        public static string Foo;
        public readonly string Bar;

        public C0507(string bar)
        {
            Bar = bar;
        }
    }
}
