using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._08._05._04
{
    /// <summary>
    ///     8.5.4 using indexes and ranges
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 <see cref="Span{T}" /> 类型直接操作集合的一部分, 而不用先复制成一个新的子集.
        /// </summary>
        [Fact]
        public void _01()
        {
            string name = "luo tao";
            var lengthOfFirstName = name.IndexOf(' ');
            var lengthOfLastName = name.Length - lengthOfFirstName - 1;

            string firstName = name[new Range(new Index(0), new Index(lengthOfFirstName))];
            string lastName = name[^lengthOfLastName..];

            Assert.Equal("luo", firstName);
            Assert.Equal("tao", lastName);
        }
    }
}
