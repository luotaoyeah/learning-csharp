using LT.LIB.BOOK.ICS7._12._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._12._01
{
    /// <summary>
    /// 12.1 enumerations
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
            Assert.Equal(1, (int) TrafficLight.Yellow);
            Assert.Equal(2, (int) TrafficLight.Red);
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // 可以定义 enum 类型的变量，它的值只能是该 enum 的某个 member，
            //----------------------------------------------------------------------------------------------------
            TrafficLight trafficLight = TrafficLight.Yellow;
            Assert.Equal(1, (int) trafficLight);
        }
    }
}
