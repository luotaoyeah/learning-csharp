using Xunit;

namespace Luotao.Test.Books.ICS7._08._02
{
    /// <summary>
    /// 8.2 accessing the inherited members
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var oc = new OtherClass();

            oc.Method01(oc.Field1);
            oc.Method01(oc.Field2);
            oc.Method02(oc.Field1);
            oc.Method02(oc.Field2);
        }
    }
}
