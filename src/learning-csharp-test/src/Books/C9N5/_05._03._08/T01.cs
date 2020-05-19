using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.C9N5._05._03._08
{
    /// <summary>
    ///     5.3.8 making a field constant
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
            Assert.Equal("Homo Sapiens", Person.Species);
        }
    }

    public class Person
    {
        /// <summary>
        ///     const 字段默认就是 static 的,
        ///     因此 static 关键字和 const 关键字不能同时使用.
        /// </summary>
        public const string Species = "Homo Sapiens";
    }
}
