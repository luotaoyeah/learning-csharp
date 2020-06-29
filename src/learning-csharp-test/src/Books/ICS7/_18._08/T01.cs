using Luotao.Lib.Books.ICS7._18._08;

namespace Luotao.Test.Books.ICS7._18._08
{
    /// <summary>
    ///     18.8 generic delegates
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
