using LT.BOOK.ICS7._16._04;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._16._04
{
    /// <summary>
    /// 16.4 an interface is a reference type
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// interface 是一个 reference 类型，它的变量可以指向一个子类的实例对象，
        /// 然后通过这个 interface variable 调用子类中实现的 method，
        /// </summary>
        [Fact]
        public void _01()
        {
            IMyInterface01 myInterface01 = new MyClass();
            Assert.Equal(6, myInterface01.F01());
            Assert.Equal(0, myInterface01.P01);
        }
    }
}
