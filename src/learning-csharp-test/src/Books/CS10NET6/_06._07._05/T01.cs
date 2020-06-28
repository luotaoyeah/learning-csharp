using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._06._07._05
{
    /// <summary>
    ///     6.7.5 understanding polymorphism
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     多态(polymorphism)可以简单理解为: 父类变量指向子类对象.
        /// </summary>
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // new 方法和 override 方法在多态时的区别:
            //----------------------------------------------------------------------------------------------------

            A b01 = new B();
            B b02 = new();

            //----------------------------------------------------------------------------------------------------
            // new 方法:
            //    通过父类变量访问的是父类的方法,
            //    通过子类变量访问的是子类的方法.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(1, b01.F01());
            Assert.Equal(2, b02.F01());

            A c01 = new C();
            C c02 = new();

            //----------------------------------------------------------------------------------------------------
            // override 方法:
            //    通过父类变量访问的是子类的方法,
            //    通过子类变量访问的是子类的方法.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(3, c01.F01());
            Assert.Equal(3, c02.F01());
        }
    }

    public class A
    {
        public virtual int F01()
        {
            return 1;
        }
    }

    public class B : A
    {
        public new int F01()
        {
            return 2;
        }
    }

    public class C : A
    {
        public override int F01()
        {
            return 3;
        }
    }
}
