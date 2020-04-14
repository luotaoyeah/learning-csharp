namespace LT.BOOK.ICS7._07._18
{
    /// <summary>
    /// 7.18 partial classes and partial types
    /// </summary>
    public partial class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 可以将一个 class 的代码分开放在不同的位置（甚至不同的文件），
        // 这些不同的部分，都必须定义为 partial class，它们最终会被编译成一个 class，
        // 从语义上讲，partial class 和普通的 class 没有区别，
        //----------------------------------------------------------------------------------------------------

        public static int Fn01()
        {
            return 6;
        }
    }
}
