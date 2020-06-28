using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._02._03._09
{
    /// <summary>
    ///     2.3.9 getting default values for types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 default() 这个 operator 获取某个类型的默认值，
        ///     reference type 的默认值都是 null，
        /// </summary>
        [Fact]
        public void _01()
        {
            Assert.Null(default(string));
            Assert.Equal(0, default);
            Assert.False(default);

            //----------------------------------------------------------------------------------------------------
            // DateTime 类型的默认值如下，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("0001-01-01 00:00:00", default(DateTime).ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        ///     如果可以推断 default() 中的类型，则可以省略类型，直接写作 default，
        /// </summary>
        [Fact]
        public void _02()
        {
            Assert.Equal(0, default);
            Assert.False(default);
        }
    }
}
