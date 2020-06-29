using Luotao.Lib.Books.ICS7._15._06;

namespace Luotao.Test.Books.ICS7._15._06
{
    /// <summary>
    ///     15.6 standard event usage
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
            var incrementer = new Incrementer();
            var dozens = new Dozens(incrementer);

            incrementer.DoCount();
            Assert.Equal(9, dozens.DozensCount);
        }
    }
}
