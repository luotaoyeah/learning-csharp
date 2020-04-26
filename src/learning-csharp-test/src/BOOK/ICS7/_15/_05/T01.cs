using LT.BOOK.ICS7._15._05;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._15._05
{
    /// <summary>
    /// 15.5 raising an event
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void _01()
        {
            var incrementer = new Incrementer();
            var dozens = new Dozens(incrementer);

            incrementer.DoCount();
            Assert.Equal(9, dozens.DozensCount);
        }
    }
}
