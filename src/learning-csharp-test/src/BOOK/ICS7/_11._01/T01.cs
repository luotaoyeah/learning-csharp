using LT.LIB.BOOK.ICS7._11._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._11._01
{
    /// <summary>
    /// 11.1 what are structs?
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
            //----------------------------------------------------------------------------------------------------
            // 由于 struct 是一个 value type，因此不需要像 class 一样使用 new 创建实例对象，
            //----------------------------------------------------------------------------------------------------
            Point point01;
            point01.X = 10;
            point01.Y = 10;

            Assert.Equal(10, point01.X);
            Assert.Equal(10, point01.Y);
        }
    }
}
