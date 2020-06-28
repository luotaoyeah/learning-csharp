using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._06._03._01
{
    /// <summary>
    ///     6.3.1 calling methods using delegates
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
            int F01(int x, int y)
            {
                testOutputHelper.WriteLine("F01");
                return x + y;
            }

            int F02(int x, int y)
            {
                testOutputHelper.WriteLine("F02");
                return x * y;
            }

            Delegate01? delegate01 = F01;
            //----------------------------------------------------------------------------------------------------
            // 使用 += 往里面添加一个方法.
            //----------------------------------------------------------------------------------------------------
            delegate01 += F02;

            //----------------------------------------------------------------------------------------------------
            // delegate 执行之后的返回值, 为它 invocation list 里面最后一个方法的返回值.
            //----------------------------------------------------------------------------------------------------
            var result = delegate01(3, 4);
            Assert.Equal(12, result);

            //----------------------------------------------------------------------------------------------------
            // 使用 -= 从里面移除一个方法.
            //----------------------------------------------------------------------------------------------------
            delegate01 -= F02;
            //----------------------------------------------------------------------------------------------------
            // 可以像执行一个方法一样执行 delegate, 也可以调用 delegate 的 Invoke() 方法来执行该 delegate.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(7, delegate01?.Invoke(3, 4));

            //----------------------------------------------------------------------------------------------------
            // 当 delegate 中的所有方法都被移除之后, 该 delegate 就等于 null.
            //----------------------------------------------------------------------------------------------------
            delegate01 -= F01;
            Assert.Null(delegate01);
        }
    }

    public delegate int Delegate01(int x, int y);
}
