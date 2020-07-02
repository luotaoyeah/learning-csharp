namespace Luotao.Test.Books.CS10NET6._03._04._06
{
    /// <summary>
    /// 3.4.6 converting from a binary object to a string
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// <para>使用 <see cref="System.Convert.ToBase64String(byte[])"/> 将二进制数据转换为 Base64 字符串.</para>
        /// <para>使用 <see cref="System.Convert.FromBase64String(string)"/> 将 Base64 字符串转换为二进制数据.</para>
        /// </summary>
        [Fact]
        public void _01()
        {
            byte[] bytes01 = new byte[128];
            new Random().NextBytes(bytes01);

            #region 打印 byte[] 的十六进制

            string hexString01 = string.Empty;

            foreach (var b in bytes01)
            {
                hexString01 += $"{b:X} ";
            }

            testOutputHelper.WriteLine("HEX:\n----------");
            testOutputHelper.WriteLine(hexString01);

            #endregion

            #region byte[] 转换为 base64

            testOutputHelper.WriteLine("\nBASE64:\n----------");
            testOutputHelper.WriteLine(Convert.ToBase64String(bytes01));

            #endregion

            #region base64 转换为 byte[]

            byte[] bytes02 = Convert.FromBase64String(Convert.ToBase64String(bytes01));
            string hexString02 = string.Empty;

            foreach (var b in bytes02)
            {
                hexString02 += $"{b:X} ";
            }

            testOutputHelper.WriteLine("\nHEX:\n----------");
            testOutputHelper.WriteLine(hexString02);

            #endregion
        }
    }
}
