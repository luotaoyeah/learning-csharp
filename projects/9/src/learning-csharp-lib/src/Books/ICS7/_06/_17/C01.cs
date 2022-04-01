namespace Luotao.Lib.Books.ICS7._06._17
{
    /// <summary>
    ///     6.17 ref local and ref return
    /// </summary>
    public class C01
    {
        public int I01 = 8;

        //----------------------------------------------------------------------------------------------------
        // 返回类型前面加上 ref，并且 return 后面加上 ref，称之为 ref return
        //----------------------------------------------------------------------------------------------------
        public ref int Fn01()
        {
            return ref I01;
        }
    }
}
