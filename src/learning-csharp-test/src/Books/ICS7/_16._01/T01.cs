using Luotao.Lib.Books.ICS7._16._01;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._16._01
{
    /// <summary>
    ///     16.1 what is an interface?
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
            var ca = new CA { Name = "luotao", Age = 18 };
            var cb = new CB { First = "luo", Last = "tao", PersonsAge = 18 };

            Assert.Equal(C01.PrintInfo(ca), C01.PrintInfo(cb));
        }
    }
}
