using Luotao.Lib.Books.ICS7._19._05._01;

namespace Luotao.Test.Books.ICS7._19._05._01
{
    /// <summary>
    ///     19.5.1 iterator blocks
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
            IEnumerator<string> enumerator = C01.BlackAndWhite();

            if (enumerator.MoveNext()) Assert.Equal("black", enumerator.Current);

            if (enumerator.MoveNext()) Assert.Equal("gray", enumerator.Current);

            if (enumerator.MoveNext()) Assert.Equal("white", enumerator.Current);

            Assert.False(enumerator.MoveNext());
        }
    }
}
