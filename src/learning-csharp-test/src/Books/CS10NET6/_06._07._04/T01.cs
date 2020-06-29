namespace Luotao.Test.Books.CS10NET6._06._07._04
{
    /// <summary>
    ///     6.7.4 preventing inheritance and overriding
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
            Assert.Equal(1, new C01().F01());
            Assert.Equal(2, new C02().F01());
            Assert.Equal(3, new C03().F01());
        }
    }

    public class C01
    {
        public virtual int F01()
        {
            return 1;
        }
    }

    /// <summary>
    ///     sealed 类不能被继承.
    /// </summary>
    public sealed class C02 : C01
    {
        public override int F01()
        {
            return 2;
        }
    }

    public class C03 : C01
    {
        /// <summary>
        ///     sealed 方法不能被 override.
        ///     sealed 用于方法时, 必须跟 override 一起用, 即 sealed 必须用于 overridden 方法.
        /// </summary>
        /// <returns></returns>
        public sealed override int F01()
        {
            return 3;
        }
    }
}
