using Xunit;

namespace Luotao.Test.Books.CS10NET6._02._02._01
{
    /// <summary>
    /// 2.2.1. showing the compiler version
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
// 下面的指令会导致编译报错，报错信息中包含 compiler 的版本和 C# 的版本
// Error CS8304 : Compiler version: '4.0.1-1.21569.2 (52021b4b)'. Language version: 10.0.
// #error version
        }
    }
}
