namespace LT.BOOK.ICS7.C04.C0410
{
    /// <summary>
    /// 4.10. Static Typing and the dynamic Keyword
    /// </summary>
    public static class C0410
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Fn01()
        {
            // .NET 平台支持多种语言, 比如 C# 和 IronPython
            //
            // 其中 C# 是一个 static typing lang,
            //   在 C# 中, 所有变量都必须声明类型, 并且会在 compile 时期进行 type checking,
            // 其中 IronPython 是一个 dynamic typing lang,
            //   在 IronPython 中, 变量的类型会在 runtime 时期进行 checking
            //
            // 那么, 如何在 C# 中使用 IronPython 编写的 assembly 呢 ?
            // C# 提供了一个 dynamic 关键字, 用来定义某个 variable 的类型,
            // 表示 compiler 不会在 compile 时期对它进行 type checking, 而是会在 runtime 时期进行

            // 如下, 方法的返回类型是 int, 而返回的 i 的类型是 dynamic,
            // 因此, 无论 i 的实际类型是什么, 在 compile 时期都不会进行检查, 因此不会编译报错
            dynamic i = "0";

            return i;
        }
    }
}
