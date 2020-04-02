namespace LT.BOOK.ICS7.C04.C0406
{
    /// <summary>
    /// 4.6. User-Defined Types
    /// </summary>
    public static class C0406
    {
        public static string Fn01()
        {
            // 除了 16 predefined types 之外, 还可以自定义 6 中类型:
            // class/interface/struct/enum/array/delegate

            return E01.Foo.ToString();
        }

        private enum E01
        {
            Foo = 9
        }
    }
}
