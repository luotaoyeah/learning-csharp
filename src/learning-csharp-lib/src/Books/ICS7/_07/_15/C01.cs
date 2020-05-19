namespace LuotaoYeah.Lib.Books.ICS7._07._15
{
    /// <summary>
    ///     7.15 the readonly modifier
    /// </summary>
    public class C01
    {
        public static readonly int I02 = 8;

        //----------------------------------------------------------------------------------------------------
        // readonly field 和 const field 的区别:
        // 
        //   const 只能在声明的时候初始化，而且必须初始化（compile time）；
        //   readonly 可以在声明的时候初始化，也可以在 constructor 中初始化（runtime）；
        //
        //   const 会在编译时替换为真正的值，不会占用内存空间；
        //   readonly 会占用内存空间；
        //----------------------------------------------------------------------------------------------------
        public readonly int I01 = 6;

        static C01()
        {
            I02 = 5;
        }

        public C01()
        {
            I01 = 8;
        }

        public C01(int i01)
        {
            I01 = i01;
        }
    }
}
