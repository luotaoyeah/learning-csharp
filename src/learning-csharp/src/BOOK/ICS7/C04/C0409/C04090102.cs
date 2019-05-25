namespace LT.BOOK.ICS7.C04.C0409
{
    /// <summary>
    /// 4.9.1.2. Automatic Initialization
    /// </summary>
    public static class C04090102
    {
        private static int i01;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Fn01()
        {
            // C# 中的 variables 有四种:
            //   1. local variable
            //   2. method parameter
            //   3. field
            //   4. array element
            //
            // 其中有些会自动被初始化为该类型的默认值, 有些不会自动被初始化
            //   1. local variable:   **不会**被初始化
            //   2. method parameter: **不会**被初始化
            //   3. field:            **会**被初始化
            //   4. array element:    **会**被初始化


            // 如下, static class field 会被初始化为默认值
            return i01;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int Fn02()
        {
            // array element 会自动被初始化为默认值
            int[] arr01 = new int[3];

            return arr01[0];
        }
    }
}