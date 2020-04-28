using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._16._11
{
    /// <summary>
    /// 16.11 interfaces can inherit interfaces
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// </summary>
        [Fact]
        public void _01()
        {
            var myClass = new LT.BOOK.ICS7._16._11.MyClass();
            Assert.Equal(1, myClass.F01());
            Assert.Equal(2, myClass.F02());
            Assert.Equal(3, myClass.F03());
        }
    }
}