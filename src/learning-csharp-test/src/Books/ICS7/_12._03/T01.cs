using System;
using LuotaoYeah.Lib.Books.ICS7._12._03;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._12._03
{
    /// <summary>
    ///     12.3 more about enums
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
            //----------------------------------------------------------------------------------------------------
            // 使用 System.Enum.GetName() 方法，获取某个 member 的 name
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(
                nameof(TrafficLight.Yellow),
                Enum.GetName(typeof(TrafficLight), 1)
            );

            //----------------------------------------------------------------------------------------------------
            // 使用 System.Enum.GetNames() 方法，获取所有的 member 的 name
            //----------------------------------------------------------------------------------------------------
            var names = Enum.GetNames(typeof(TrafficLight));
            Assert.Equal(nameof(TrafficLight.Green), names[0]);
            Assert.Equal(nameof(TrafficLight.Yellow), names[1]);
            Assert.Equal(nameof(TrafficLight.Red), names[2]);
        }
    }
}
