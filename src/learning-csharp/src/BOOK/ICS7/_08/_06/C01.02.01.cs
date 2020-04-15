namespace LT.BOOK.ICS7._08._06
{
    /// <summary>
    /// 8.6.2.1 case 1: declaring print with override
    /// </summary>
    public class C010201
    {
    }

    public class MyBaseClass
    {
        public virtual int Print()
        {
            return 1;
        }
    }

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
