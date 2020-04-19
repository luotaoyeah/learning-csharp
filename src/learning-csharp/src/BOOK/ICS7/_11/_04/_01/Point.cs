namespace LT.BOOK.ICS7._11._04._01
{
    //----------------------------------------------------------------------------------------------------
    // struct 默认都会隐式地定义一个 parameterless constructor，这个 parameterless constructor 不能被删除/修改，
    // 因此我们只能定义有参数的 constructor，
    //----------------------------------------------------------------------------------------------------
    public struct Simple
    {
        public int X;
        public int Y;

        public Simple(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
