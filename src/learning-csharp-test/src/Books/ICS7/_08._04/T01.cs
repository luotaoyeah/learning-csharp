using Xunit;

namespace Luotao.Test.Books.ICS7._08._04
{
    /// <summary>
    /// 8.4 masking members of a base class
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var oc = new OtherClass();
            oc.Method01(oc.Field1);
        }
    }
}
