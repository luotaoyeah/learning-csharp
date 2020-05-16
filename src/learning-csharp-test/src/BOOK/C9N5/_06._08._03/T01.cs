using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._06._08._03
{
    /// <summary>
    ///     6.8.3 avoiding casting exceptions
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
            Assert.Throws<InvalidCastException>(C01.F01);
            Assert.Equal(2, C01.F02());
            Assert.Equal(2, C01.F03());
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

    public class C01
    {
        /// <summary>
        ///     使用圆括号将父类变量转换为子类变量,
        ///     只有在父类变量指向的确实是子类对象时才能转换成功, 否则抛出 <see cref="System.InvalidCastException" /> 异常.
        /// </summary>
        public static void F01()
        {
            A a = new();
            B b = (B) a;
        }

        /// <summary>
        ///     使用圆括号转换成功.
        /// </summary>
        /// <returns></returns>
        public static int F02()
        {
            A a = new B();
            B b = (B) a;
            return b.F01();
        }

        /// <summary>
        ///     还可以使用 as 来转换,
        ///     圆括号转换失败会抛出 <see cref="System.InvalidCastException" /> 异常,
        ///     而 as 转换失败会返回 null, 不会抛出异常.
        /// </summary>
        /// <returns></returns>
        public static int F03()
        {
            A a = new B();
            var b = a as B;

            return b?.F01() ?? 0;
        }
    }
}
