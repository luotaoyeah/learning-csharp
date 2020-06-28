using Luotao.Lib.Books.CS10NET6._05;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._02._02
{
    /// <summary>
    ///     5.2.2 instantiating a class
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
            var person = new Person();
            Assert.Equal("Luotao.Lib.Books.CS10NET6._05.Person", person.ToString());
        }
    }
}
