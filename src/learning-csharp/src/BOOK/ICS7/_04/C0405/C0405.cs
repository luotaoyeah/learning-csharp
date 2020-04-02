namespace LT.BOOK.ICS7.C04.C0405
{
    /// <summary>
    /// 4.5. Predefined Types
    /// </summary>
    public static class C0405
    {
        public static string Fn01()
        {
            /*
             * C# provides 16 predefined types,
             * all of the 16 predefined types are lowercase
             */

            //   1. object
            //   2. string
            //   3. dynamic
            //   4. bool
            //   5. char
            //   6. sbyte
            //   7. byte
            //   8. short
            //   9. ushort
            //  10. int
            //  11. uint
            //  12. long
            //  13. ulong
            //  14. float
            //  15. double
            //  16. decimal

            const long l01 = 9;
            // float value 可以加上 f 后缀
            const float f01 = 0.01f;
            // double value 可以加上 d 后缀
            const double d01 = 0.01d;
            // decimal value 可以加上 m 后缀
            const decimal d02 = 0.01m;
            return $"{l01},{f01},{d01},{d02}";
        }
    }
}
