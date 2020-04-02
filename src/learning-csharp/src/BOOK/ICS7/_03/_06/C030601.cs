namespace LT.BOOK.ICS7.C03.C0306
{
    /// <summary>
    /// 3.6.1. Blocks
    /// </summary>
    public static class C030601
    {
        public static string Fn01()
        {
            string foo;

            // {} 之间可以包含多个 statements, 称之为 block
            {
                const int i01 = 9;
                foo = $"9{i01}9";
            }

            return foo;
        }
    }
}
