namespace Luotao.Lib.Books.ICS7._08._06._02._01
{
    public class SecondDerived : MyDerivedClass
    {
        //----------------------------------------------------------------------------------------------------
        // 孙类可以继续 override 父类的 virtual 方法
        //----------------------------------------------------------------------------------------------------
        public override int Print()
        {
            return 3;
        }
    }
}
