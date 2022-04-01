using Luotao.Lib.Books.ICS7._18._07;

namespace Luotao.Test.Books.ICS7._18._07
{
    /// <summary>
    ///     18.7 generic structs
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
            var pieceOfData = new PieceOfData<int>(3);
            Assert.Equal(3, pieceOfData.Data);
        }
    }
}
