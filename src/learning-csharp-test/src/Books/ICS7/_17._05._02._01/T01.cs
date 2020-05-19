using System;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._17._05._02._01
{
    /// <summary>
    ///     17.5.2.1 the checked and unchecked operators
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     显式转换 integer 类型可能会发生数据损失，
        ///     默认情况下，即使发生了数据损失，依然可以转换成功，
        ///     我们可以使用 checked(...) 表示里面的类型转换需要进行检查，如果会发生数据损失，则会抛出 OverflowException 异常
        /// </summary>
        [Fact]
        public void _01()
        {
            ushort sh = 2000;

            // unchecked operator
            var sb01 = unchecked((byte) sh);
            Assert.Equal(208, sb01);

            try
            {
                // checked statement
                checked
                {
                    var sb02 = (byte) sh;
                }
            }
            catch (OverflowException e)
            {
                testOutputHelper.WriteLine(e.Message);
            }
        }
    }
}
