using LT.BOOK.ICS7._15._06._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._15._06._01
{
    /// <summary>
    /// 15.6.1 passing data by extending eventargs
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
            incrementer.CountedADozen += (_, incrementerEventArgs) =>
            {
                testOutputHelper.WriteLine(incrementerEventArgs.IterationCount.ToString());
            };

            incrementer.DoCount();
        }
    }
}
