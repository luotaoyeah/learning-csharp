using System;

namespace LT.BOOK.ICS7.C04.C0405
{
    /// <summary>
    /// 4.5.1. More About the Predefined Types
    /// </summary>
    public static class C040501
    {
        public static bool Fn01()
        {
            // 16 predefined types 每一个类型都对应一个底层的 .NET 类型,
            // 比如 int 对应 System.Int32 类型,
            // int 只是 System.Int32 的一个别名(alias)

            const int i01 = 9;
            const Int32 i02 = 9;

            const bool b01 = true;
            const Boolean b02 = false;

            return i01 == i02 && b01 != b02;
        }

        public static string Fn02()
        {
            const string s01 = "FOO";
            const String s02 = "BAR";

            return $"{s01}{s02}";
        }
    }
}
