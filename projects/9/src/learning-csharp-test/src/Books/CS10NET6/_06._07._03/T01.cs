namespace Luotao.Test.Books.CS10NET6._06._07._03
{
    /// <summary>
    ///     6.7.3 overriding members
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            Assert.Equal(1, new C01().F01());
            Assert.Equal(2, new C02().F01());
        }
    }

    public class C01
    {
        /// <summary>
        ///     父类的方法声明为 virtual, 则子类可以 override 该方法.
        /// </summary>
        /// <returns></returns>
        public virtual int F01()
        {
            Console.WriteLine($"{nameof(C01)}.{nameof(F01)}()");
            return 1;
        }
    }

    public class C02 : C01
    {
        public override int F01()
        {
            //----------------------------------------------------------------------------------------------------
            // 在子类中通过 base 访问父类的成员.
            //----------------------------------------------------------------------------------------------------
            base.F01();

            Console.WriteLine($"{nameof(C02)}.{nameof(F01)}()");
            return 2;
        }
    }
}
