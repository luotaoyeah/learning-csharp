namespace LuotaoYeah.Lib.Books.ICS7._08._06._02._01
{
    public class MyDerivedClass : MyBaseClass
    {
        //----------------------------------------------------------------------------------------------------
        // 子类可以 override 父类的 virtual 方法
        //----------------------------------------------------------------------------------------------------
        public override int Print()
        {
            return 2;
        }
    }
}
