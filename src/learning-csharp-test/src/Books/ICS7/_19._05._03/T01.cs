using LuotaoYeah.Lib.Books.ICS7._19._05._03;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._19._05._03
{
    /// <summary>
    ///     19.5.3 using an iterator to create an enumerable
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
            var myClass = new MyClass();

            foreach (var s in myClass) testOutputHelper.WriteLine(s);
        }
    }
}
