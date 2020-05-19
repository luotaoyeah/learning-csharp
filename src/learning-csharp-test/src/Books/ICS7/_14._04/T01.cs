using Luotao.Lib.Books.ICS7._14._04;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._14._04
{
    /// <summary>
    ///     14.4 creating the delegate object
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
            var c01 = new C01();

            //----------------------------------------------------------------------------------------------------
            // 使用 object-creation expression 语句创建一个 delegate 对象，
            // 必须传一个 method 作为参数，这个 method 会成为该 delegate 对象的 invocation list 中的第一个 method，
            //----------------------------------------------------------------------------------------------------
            MyDel myDel = c01.Fn01;

            //----------------------------------------------------------------------------------------------------
            // invocation list 中的 method 可以是 instance method 或者 static method，
            // 只要 method 的 signature 和 return type 是匹配的，
            //----------------------------------------------------------------------------------------------------
            myDel = C01.Fn02;

            //----------------------------------------------------------------------------------------------------
            // 可以直接将一个 method 赋值给 delegate，会自动进行隐式类型转换
            //----------------------------------------------------------------------------------------------------
            myDel = c01.Fn01;

            Assert.Equal(4, myDel(2));
        }
    }
}
