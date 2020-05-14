using LT.LIB.BOOK.ICS7._08._11._01;
using Xunit;

namespace LT.TEST.BOOK.ICS7._08._11._01
{
    /// <summary>
    /// 8.11.1 example of an abstract class and an abstract method
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var derivedClass = new DerivedClass();
            Assert.Equal("I am AbClass", derivedClass.IdentifyBase());
            Assert.Equal("I am DerivedClass", derivedClass.IdentifyDerived());
        }
    }
}
