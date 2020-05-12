using System;

namespace LT.LIB.BOOK.ICS7._07._12
{
    /// <summary>
    /// 7.12 static constructors
    /// </summary>
    public class C01
    {
        public static int age;

        //----------------------------------------------------------------------------------------------------
        // static constructor 的特点：
        //   1. 使用 static 关键字，
        //   2. 不能定义 parameter，
        //   3. 不能使用 access modifier，
        //
        // 不能在程序中调用 static constructor，它由系统自动调用，
        // 通常在 static constructor 中初始化 static field 等数据，
        //----------------------------------------------------------------------------------------------------
        static C01()
        {
            age = 2;
            Console.Write("222");
        }
    }
}
