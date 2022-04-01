using Luotao.Lib.Books.ICS7._18._05;

namespace Luotao.Test.Books.ICS7._18._05
{
    /// <summary>
    ///     18.5 generic methods
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
            Assert.Equal(1, C01.F01(1, 1));
            Assert.Equal(2.2, C01.F01(1.1, 2.2));
        }
    }
}
