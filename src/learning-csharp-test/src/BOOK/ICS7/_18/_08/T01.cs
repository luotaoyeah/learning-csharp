using LT.BOOK.ICS7._18._08;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._18._08
{
    /// <summary>
    /// 18.7 generic structs
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
            var myDelegate01 = new MyDelegate<string>(Simple.PrintString);
            Assert.Equal("FOO", myDelegate01("foo"));

            var myDelegate02 = new MyDelegate<int>(Simple.PrintInt);
            Assert.Equal(2, myDelegate02(2));
        }
    }
}
