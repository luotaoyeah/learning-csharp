namespace Luotao.Lib.Books.ICS7._08._07._01
{
    public class MyDerivedClass : MyBaseClass
    {
        public int A;

        //----------------------------------------------------------------------------------------------------
        // 子类的 constructor 默认会调用父类的 parameterless constructor，
        // 即下面的代码等价于后面加上 ` : base()`
        //----------------------------------------------------------------------------------------------------
        public MyDerivedClass()
        {
        }

        //----------------------------------------------------------------------------------------------------
        // 可以通过 ` : base(...)` 调用父类其他的 constructor，
        //----------------------------------------------------------------------------------------------------
        public MyDerivedClass(int x, int a) : base(x)
        {
            A = a;
        }

        //----------------------------------------------------------------------------------------------------
        // 可以通过 ` : this(...)` 调用子类自己其他的 constructor，
        //----------------------------------------------------------------------------------------------------
        public MyDerivedClass(int x) : this(x, 2)
        {
        }
    }
}
