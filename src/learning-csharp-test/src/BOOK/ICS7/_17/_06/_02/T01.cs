using System;
using LT.BOOK.ICS7._17._06._02;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._17._06._02
{
    /// <summary>
    /// 17.6.2 explicit reference conversions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// 显式地将父类转换为子类，会在 runtime 抛出 <see cref="InvalidCastException"/> 异常
        /// </summary>
        [Fact]
        public void _01()
        {
            var a = new A();
            try
            {
                B b = (B) a;
            }
            catch (InvalidCastException e)
            {
                testOutputHelper.WriteLine(e.Message);
            }
        }
    }
}
