namespace LT.BOOK.ICS7.C04.C0409
{
    /// <summary>
    /// 4.9.1.1. Variable Initializers
    /// </summary>
    public static class C04090101
    {
        public static int Fn01()
        {
            // 声明变量的时候, 可以同时进行初始化
            const int i01 = 9;

            // local variable 在使用之前必须先进行赋值, 否则编译报错
            int i02;

            return i01;
        }
    }
}
