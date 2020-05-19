using System;
using System.Collections;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._17._06._01
{
    /// <summary>
    ///     17.6.1 implicit reference conversions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     任何 reference type 都可以隐式转换为 object 类型，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };
            object obj01 = arr01;
            Assert.Equal($"{nameof(System)}.{nameof(Int32)}[]", obj01.ToString());
        }

        /// <summary>
        ///     任何子类都可以隐式转换为父类（包括接口）
        /// </summary>
        [Fact]
        public void _02()
        {
            int[] arr01 = { 1, 2, 3 };
            IList obj01 = arr01;
            Assert.Equal(1, obj01.IndexOf(2));
        }
    }
}
