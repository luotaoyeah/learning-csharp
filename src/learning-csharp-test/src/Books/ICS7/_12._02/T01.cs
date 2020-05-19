using Luotao.Lib.Books.ICS7._12._02;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._12._02
{
    /// <summary>
    ///     12.2 bit flags
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
            // 使用 System.Enum.HasFlag() 方法，判断是否包含了某一个（某一些） bit
            //----------------------------------------------------------------------------------------------------
            var cardDeckSettings = CardDeckSettings.A | CardDeckSettings.B;
            Assert.True(cardDeckSettings.HasFlag(CardDeckSettings.A));
            Assert.False(cardDeckSettings.HasFlag(CardDeckSettings.C));

            //----------------------------------------------------------------------------------------------------
            // 使用 bit AND 来判断是否包含
            //----------------------------------------------------------------------------------------------------
            Assert.True((cardDeckSettings & CardDeckSettings.A) == CardDeckSettings.A);
            Assert.True((cardDeckSettings & CardDeckSettings.B) == CardDeckSettings.B);
        }
    }
}
