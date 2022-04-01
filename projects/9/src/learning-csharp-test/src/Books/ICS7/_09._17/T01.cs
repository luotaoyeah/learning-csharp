using Luotao.Lib.Books.ICS7._09._17;

namespace Luotao.Test.Books.ICS7._09._17
{
    /// <summary>
    ///     9.17 the nameof operator
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // nameof operator 返回某个 type/member/variable/paramter 等等的名称
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("MyClass", nameof(MyClass));
            Assert.Equal("X", nameof(MyClass.X));
            Assert.Equal("Fn01", nameof(MyClass.Fn01));

            const int i01 = 0;
            Assert.Equal("i01", nameof(i01));
        }
    }
}
