using System.Diagnostics;

namespace LT.BOOK.ICS7.C03.C0303
{
    /// <summary>
    /// 3.3. Keywords
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class C0303
    {
        public static string Fn01()
        {
            // keywords cannot be used as identifiers,
            // unless prefaced with "@"
            const string @string = "FOO";
            return @string;
        }
    }
}