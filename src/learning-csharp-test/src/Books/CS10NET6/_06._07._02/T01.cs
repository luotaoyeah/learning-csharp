using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._06._07._02
{
    /// <summary>
    ///     6.7.2 hiding members
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
        public int F01()
        {
            Console.WriteLine($"{nameof(C01)}.{nameof(F01)}()");
            return 1;
        }
    }

    public class C02 : C01
    {
        /// <summary>
        ///     子类定义父类的同名方法, 前面需要加上关键字 new, 表示该方法会隐藏父类的同名方法.
        /// </summary>
        /// <returns></returns>
        public new int F01()
        {
            Console.WriteLine($"{nameof(C02)}.{nameof(F01)}()");
            return 2;
        }
    }
}
