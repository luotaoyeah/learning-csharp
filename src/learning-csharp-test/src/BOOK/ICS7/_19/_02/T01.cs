using System.Collections;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._19._02
{
    /// <summary>
    /// 19.2 the IEnumerator interface
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
            int[] arr01 = { 1, 2, 3 };

            IEnumerator enumerator = arr01.GetEnumerator();

            if (enumerator.MoveNext())
            {
                Assert.Equal(1, enumerator.Current);
            }

            if (enumerator.MoveNext())
            {
                Assert.Equal(2, enumerator.Current);
            }

            if (enumerator.MoveNext())
            {
                Assert.Equal(3, enumerator.Current);
            }

            Assert.False(enumerator.MoveNext());
        }
    }
}
