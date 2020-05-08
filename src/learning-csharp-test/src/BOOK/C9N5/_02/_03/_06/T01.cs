using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._02._03._06
{
    /// <summary>
    /// 2.3.6 storing any type of object
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// object 是所有类型的基类
        /// </summary>
        [Fact]
        public void _01()
        {
            object height = 1.88;
            object name = "luotao";
            testOutputHelper.WriteLine($"{name} is {height} meters tall.");

            //----------------------------------------------------------------------------------------------------
            // 将 object 类型强制转换为实际的类型
            //----------------------------------------------------------------------------------------------------
            int length = ((string) name).Length;
            testOutputHelper.WriteLine($"{name} has {length} characters.");
        }
    }
}
