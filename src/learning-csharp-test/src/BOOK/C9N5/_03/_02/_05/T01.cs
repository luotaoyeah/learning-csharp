using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._03._02._05
{
    /// <summary>
    /// 3.2.5 pattern matching with the switch statement
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// case 后面也可以使用模式匹配(pattern matching)
        /// </summary>
        [Fact]
        public void _01()
        {
            Stream stream;

            if (new Random().Next(1, 9) < 5)
            {
                stream = new FileStream("D:/proj/git/luotaoyeah/learning-csharp/src/learning-csharp-test/src/BOOK/C9N5/_03/_02/_05/T01.cs", FileMode.Open);
            }
            else
            {
                stream = new MemoryStream();
            }

            switch (stream)
            {
                // 使用 when 对匹配条件进一步限制
                case FileStream fileStream when fileStream.CanWrite:
                    testOutputHelper.WriteLine("{0}:{1}", nameof(FileStream), fileStream.CanWrite);
                    break;
                case MemoryStream memoryStream:
                    testOutputHelper.WriteLine("{0}:{1}", nameof(MemoryStream), memoryStream.CanWrite);
                    break;
            }
        }
    }
}
