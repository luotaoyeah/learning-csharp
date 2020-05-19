namespace Luotao.Lib.Books.ICS7._08._05
{
    /// <summary>
    ///     8.5 base access
    /// </summary>
    public class C01
    {
        protected int I01 = 2;
    }

    public class C02 : C01
    {
        private new readonly int I01 = 1;

        public int Fn01()
        {
            return I01;
        }

        public int Fn02()
        {
            //----------------------------------------------------------------------------------------------------
            // 如果父类的 member 被子类隐藏了，在子类中可以通过 base.XXX 访问这个被隐藏的 member 
            //----------------------------------------------------------------------------------------------------
            return base.I01;
        }
    }
}
