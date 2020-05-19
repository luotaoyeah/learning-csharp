using LuotaoYeah.Lib.Books.ICS7._12._01._01;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._12._01._01
{
    /// <summary>
    ///     12.1.1 setting the underlying type and explicit values
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
            Assert.Equal(0, (int) TrafficLight.Green);
            Assert.Equal(3, (int) TrafficLight.Yellow);
            Assert.Equal(4, (int) TrafficLight.Red);
        }
    }
}
