namespace LT.BOOK.ICS7.C04.C0408
{
    /// <summary>
    /// 4.8. Value Types and Reference Types
    /// </summary>
    public static class C0408
    {
        public static void Fn01()
        {
            // there are two types: value types / reference types
            // value types are stroed on the stack
            // reference types have two parts: the reference / the data
            //   the reference is stored on the stack
            //   the data is stored on the heap

            // 对于一个 reference type object 下面的成员来说,
            // 因为 reference type object 的 data 是存储在 heap 上的,
            // 而它的成员, 无论是 data type member 还是 reference type member, 都是 data 的一部分,
            // 因此, 它们都是存储在 heap 上的
        }
    }
}