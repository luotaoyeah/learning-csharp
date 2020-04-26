using LT.BOOK.ICS7._16._10;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._16._10
{
    /// <summary>
    /// 16.10 explicit interface member implementations
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// explicit interface member implementation 只能通过 interface variable 来访问，不能通过 class instance 来访问，
        /// </summary>
        [Fact]
        public void _01()
        {
            var myClass = new MyClass();

            IMyInterface01 interface01 = myClass;
            Assert.Equal(1, interface01.F01());

            IMyInterface02 interface02 = myClass;
            Assert.Equal(2, interface02.F01());
        }
    }
}
