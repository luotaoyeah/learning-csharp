namespace LT.BOOK.ICS7.C04.C0409
{
    /// <summary>
    /// 4.9.2. Multiple-Variable Declarations
    /// </summary>
    public static class C040902
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Fn01()
        {
            // 可以同时定义多个类型相同的变量, 使用逗号进行分隔
            // 可以设置初始值, 也可以不设置初始值

            int i01 = 9, i02, i03 = 99;

            return i01 + i03;
        }
    }
}