using System;
using LuotaoYeah.Lib.Books.ICS7._17._11;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._17._11
{
    /// <summary>
    ///     17.11 the as operator
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 () 显示转换类型，如果转换失败，会抛出 <see cref="InvalidCastException" /> 异常，
        ///     使用 as 显示转换类型，如果转换失败，会返回 null，
        /// </summary>
        [Fact]
        public void _01()
        {
            var person = new Person();
            var employee = person as Employee;
            Assert.Null(employee);
        }
    }
}
