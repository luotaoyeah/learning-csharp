using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Docs.Csharp.LanguageReference.Keywords.init
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init.
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
            // 在 object initializer 中给 init accessor 赋值
            var initExample01 = new InitExample { Seconds = 6 };
            Assert.Equal(6, initExample01.Seconds);

            // 在 constructor 参数给 init accessor 赋值
            var initExample02 = new InitExample(6);
            Assert.Equal(6, initExample02.Seconds);
        }

        [Fact]
        public void _02()
        {
            var initExample01 = new InitExample { [0] = 6 };
            Assert.Equal(6, initExample01[0]);
        }
    }
}
