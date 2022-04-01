using Luotao.Lib.Books.ICS7._18._06;

namespace Luotao.Test.Books.ICS7._18._06
{
    /// <summary>
    ///     18.6 extension methods with generic classes
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
            Assert.Equal(1, new Holder().F01(1));

            Assert.Equal(1, new Holder().F02(1));
            Assert.Equal(3.14, new Holder().F02(3.14));
        }
    }
}
