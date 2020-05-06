using System.Threading.Tasks;
using LT.BOOK.ICS7._21._03;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._21._03
{
    /// <summary>
    /// 21.3 what is an async method
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
            Task<int> task = DoAsyncStuff.CalculateSumAsync(5, 6);
            Assert.Equal(11, task.Result);
        }

        [Fact]
        public async void _02()
        {
            Task<int> task = DoAsyncStuff.CalculateSumAsync(5, 6);
            int value = await task;
            Assert.Equal(11, value);
        }

        [Fact]
        public async void _03()
        {
            int value = await DoAsyncStuff.CalculateSumAsync(5, 6);
            Assert.Equal(11, value);
        }
    }
}
