namespace Luotao.Test.Books.CS10NET6._03._02._04
{
    /// <summary>
    /// 3.2.4 pattern matching with the switch statement
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// case 后面也可以使用模式匹配(pattern matching).
        /// </summary>
        [Fact]
        public void _01()
        {
            Stream stream;

            if (new Random().Next(1, 9) < 5)
            {
                stream = new FileStream(
                    @"D:\proj\git\luotaoyeah\learning-csharp\src\learning-csharp-test\src\Books\CS10NET6\_03._02._04\T01.cs",
                    FileMode.Open,
                    FileAccess.ReadWrite
                );
            }
            else
            {
                stream = new MemoryStream();
            }

            switch (stream)
            {
                // 首先判断 stream 是否是 FileStream 类型,
                // 然后使用 when 作进一步的判断
                case FileStream fileStream when stream.CanWrite:
                    testOutputHelper.WriteLine("{0}: {1}", nameof(FileStream), fileStream.CanWrite);
                    break;
                case MemoryStream memoryStream:
                    testOutputHelper.WriteLine("{0}: {1}", nameof(MemoryStream), memoryStream.CanWrite);
                    break;
                default:
                    testOutputHelper.WriteLine($"{nameof(stream)}: {stream.CanWrite}");
                    break;
            }
        }
    }
}
