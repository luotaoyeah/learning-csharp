using Luotao.Lib.Books.CS10NET6._02;

namespace Luotao.Test.Books.CS10NET6._02._03._09._02
{
    /// <summary>
    /// 2.3.9.2. inferring the type of a local variable
    /// </summary>
    public class T01
    {
        /// <summary>
        /// var 表示根据后面赋的值来推断变量类型.
        /// </summary>
        [Fact]
        public void _01()
        {
            // 像这种一眼就可以看出变量类型的, 就适合用 var
            var xmlDocument01 = new XmlDocument();

            // 像这种无法一眼就看出变量类型的, 就不适合用 var, 而应该显示声明变量类型
            bool exists = File.Exists("");
        }
    }
}
