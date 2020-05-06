using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._20._06._04
{
    /// <summary>
    /// 20.6.4 the LINQ predefined delegate types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// .net 预定义了两个常用的 delegate 类型：Func 和 Action
        /// </summary>
        [Fact]
        public void _01()
        {
            Func<int> func01 = () => 6;
            Assert.Equal(6, func01.Invoke());

            Func<int, int> func02 = (_) => 6;
            Assert.Equal(6, func02.Invoke(0));

            Func<int, int, int> func03 = (_, _) => 6;
            Assert.Equal(6, func03.Invoke(0, 0));

            Action<int> action = (int x) => { testOutputHelper.WriteLine(x.ToString()); };
            action.Invoke(0);
        }
    }
}
