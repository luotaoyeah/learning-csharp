using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._03._04._06
{
    /// <summary>
    /// 3.4.6 parsing from strings to numbers or dates and times
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 将字符串转换为数字/日期.
        /// </summary>
        [Fact]
        public void _01()
        {
            int i01 = int.Parse("6");
            Assert.Equal(6, i01);
        }

        /// <summary>
        /// <see cref="System.Int32.Parse(string)"/> 方法转换失败时会抛出异常.
        /// </summary>
        [Fact]
        public void _02()
        {
            Assert.Throws<FormatException>(ParseIntFail);
        }

        /// <summary>
        /// <see cref="System.Int32.TryParse(string?, out int)"/> 方法转换失败时会返回 false,
        /// 转化成功时会返回 true, 并将转换结果存到 out 参数中.
        /// </summary>
        [Fact]
        public void _03()
        {
            int i01;

            Assert.False(int.TryParse("A", out i01));
            Assert.Equal(0, i01);

            Assert.True(int.TryParse("6", out i01));
            Assert.Equal(6, i01);
        }

        private void ParseIntFail()
        {
            int i01 = int.Parse("A");
        }
    }
}
