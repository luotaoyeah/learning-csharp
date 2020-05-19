using System.Threading.Tasks;
using LuotaoYeah.Lib.Books.ICS7._21._03;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._21._03
{
    /// <summary>
    ///     21.3 what is an async method
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
            var value = await task;
            Assert.Equal(11, value);
        }

        [Fact]
        public async void _03()
        {
            var value = await DoAsyncStuff.CalculateSumAsync(5, 6);
            Assert.Equal(11, value);
        }

        [Fact]
        public void _04()
        {
            Task task = new DoAsyncStuff02(testOutputHelper.WriteLine).CalculateSumAsync(5, 6);
            task.Wait();
            testOutputHelper.WriteLine("Async stuff is done");
        }

        [Fact]
        public void _05()
        {
            Task task = new DoAsyncStuff02(testOutputHelper.WriteLine).CalculateSumAsync(5, 6);
            task.ContinueWith(_ => { testOutputHelper.WriteLine("Async stuff is done"); });
        }

        [Fact]
        public async void _06()
        {
            await new DoAsyncStuff02(testOutputHelper.WriteLine).CalculateSumAsync(5, 6);
            testOutputHelper.WriteLine("Async stuff is done");
        }

        [Fact]
        public void _07()
        {
            //----------------------------------------------------------------------------------------------------
            // 返回类型为 void 的 async method，调用之后就无法再跟它进行交互，
            //----------------------------------------------------------------------------------------------------
            new DoAsyncStuff03(testOutputHelper.WriteLine).CalculateSumAsync(5, 6);
            testOutputHelper.WriteLine("Async stuff is done");
        }
    }
}
