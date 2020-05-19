using LuotaoYeah.Lib.Books.C9N5._05;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._05._03._04
{
    /// <summary>
    ///     5.3.4 storing a value using an enum type
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     enum 底层存的是 int 值, 因此 enum 是值类型, 它的默认值为 0.
        /// </summary>
        [Fact]
        public void _01()
        {
            var person = new Person();
            Assert.Equal(0, (int) person.Favorite);
            Assert.Equal(0, (int) default(WondersOfTheAncientWorld));
        }

        /// <summary>
        ///     可以将 int 值转换为 enum 值.
        /// </summary>
        [Fact]
        public void _02()
        {
            var person = new Person();

            person.Favorite = (WondersOfTheAncientWorld) 3;
            Assert.Equal("D", person.Favorite.ToString());

            person.Favorite = (WondersOfTheAncientWorld) 9;
            Assert.Equal("9", person.Favorite.ToString());
        }
    }
}
