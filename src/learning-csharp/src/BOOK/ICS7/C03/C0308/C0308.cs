using System;

namespace LT.BOOK.ICS7.C03.C0308
{
    /// <summary>
    /// 3.8. Comments: Annotating the Code
    /// </summary>
    public static class C0308
    {
        public static void Fn01()
        {
            // C# support single-line comments and delimited comments(multiple-line comments)

            /*
             * SOME COMMENTS
             */

            // delimited comments can not be nestes
            // inivalid delimited comments: /* /* SOME COMMENTS */ */

            Console.WriteLine("0" /*SOME COMMENTS*/);
        }
    }
}