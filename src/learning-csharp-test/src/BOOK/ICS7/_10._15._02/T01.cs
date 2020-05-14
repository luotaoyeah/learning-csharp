using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._10._15._02
{
    /// <summary>
    /// 10.15.2 example of the using statement
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
            // resource 指的是实现了 System.IDisposable 接口的 class/struct，
            // resource 在使用完/抛异常之后需要释放，通常使用 try/finally 来处理资源的释放，
            // using statement 可以简化这个资源释放的操作，
            //----------------------------------------------------------------------------------------------------
            using (TextWriter textWriter = File.CreateText("T01.txt"))
            {
                textWriter.WriteLine("床前明月光，");
                textWriter.WriteLine("疑是地上霜，");
                textWriter.WriteLine("举头望明月，");
                textWriter.WriteLine("低头思故乡。");
            }

            using (TextReader textReader = File.OpenText("T01.txt"))
            {
                string line;
                while (null != (line = textReader.ReadLine()))
                {
                    testOutputHelper.WriteLine(line);
                }
            }
        }
    }
}
