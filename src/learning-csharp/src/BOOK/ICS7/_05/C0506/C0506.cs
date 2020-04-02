namespace LT.BOOK.ICS7.C05.C0506
{
    /// <summary>
    /// 5.6. Allocating Memory for the Data
    /// </summary>
    public class C0506
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Fn01()
        {
            // 使用 new 关键字来创建一个 class 的实例,
            // 因为 class 是 reference type,
            // 因此, 变量 c01 是保存在 stack 上的, 它所指向的实例是保存在 heap 上的 
            C01 c01 = new C01();
            return C01.X;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Fn02()
        {
            // 也可以使用 new 来创建一个 int 的实例,
            // 因为 int 是 value type,
            // 因此, 变量 i01 和它所指向的实例都是保存在 stack 上的
            const int i01 = new int();
            return i01;
        }
    }

    public class C01
    {
        public const int X = 9;
    }
}
