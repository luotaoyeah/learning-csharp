using System.Diagnostics;

namespace LT.BOOK.ICS7.C03.C0302
{
    /// <summary>
    /// 3.2. Identifiers
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class C0302
    {
        public static void Fn01()
        {
            // 标识符 (identifier) 可以以 a-aA-Z_ 开头

            const string a01 = "FOO";
            // ReSharper disable once InconsistentNaming
            const string A01 = "BAR";
            // ReSharper disable once InconsistentNaming
            const string _01 = "BAZ";


            Debug.Assert(string.Equals(a01 + A01 + _01, "FOOBARBAZ"));
        }

        public static void Fn02()
        {
            // 标识符区分大小写 (case-sensitive)

            const string foo = "FOO";
            // ReSharper disable once InconsistentNaming
            const string Foo = "FOO";

            Debug.Assert(string.Equals(foo, Foo));
        }
    }
}