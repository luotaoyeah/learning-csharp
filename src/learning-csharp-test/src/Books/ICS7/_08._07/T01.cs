using Luotao.Lib.Books.ICS7._08._07;
using Xunit;

namespace Luotao.Test.Books.ICS7._08._07
{
    /// <summary>
    ///     8.7 constructor execution
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 创建子类实例时，会先调用父类的 constructor，再调用子类的 constructor，
            // 默认调用的是父类的 parameterless constructor，因此如果父类没有 parameterless constructor，会编译报错，
            //----------------------------------------------------------------------------------------------------
            var myDerivedClass = new MyDerivedClass();
        }
    }
}
