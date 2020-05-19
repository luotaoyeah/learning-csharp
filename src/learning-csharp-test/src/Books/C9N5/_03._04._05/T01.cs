using System;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._03._04._05
{
    /// <summary>
    ///     3.4.5 converting from a binary object to a string
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     将二进制数据转换为 base64 字符串.
        /// </summary>
        [Fact]
        public void _01()
        {
            byte[] bytes = new byte[128];
            new Random().NextBytes(bytes);

            string hexString = string.Empty;

            foreach (var b in bytes) hexString += $"{b:X} ";

            testOutputHelper.WriteLine("HEX:\n----------");
            testOutputHelper.WriteLine(hexString);

            testOutputHelper.WriteLine("\nBASE64:\n----------");
            testOutputHelper.WriteLine(Convert.ToBase64String(bytes));
        }
    }
}
