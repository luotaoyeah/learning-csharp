using Luotao.Lib.Books.ICS7._09._14._01;

namespace Luotao.Test.Books.ICS7._09._14._01
{
    /// <summary>
    ///     9.14.1 explicit conversion and the cast operator
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 显式类型转换必须使用 cast operator（也就是圆括号）
            //----------------------------------------------------------------------------------------------------
            LimitedInt limitedInt = (LimitedInt)500;
            Assert.Equal(100, limitedInt.TheValue);

            var i01 = (int)limitedInt;
            Assert.Equal(100, i01);
        }
    }
}
