using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._03._09
{
    /// <summary>
    ///     5.3.9 making a field read-only
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
            Assert.Equal("Earth", person.HomePlanet);
        }
    }

    public class Person
    {
        /// <summary>
        ///     readonly 字段可以是 instance 字段, 也可以是 static 字段.
        /// </summary>
        public readonly string HomePlanet = "Earth";
    }
}
