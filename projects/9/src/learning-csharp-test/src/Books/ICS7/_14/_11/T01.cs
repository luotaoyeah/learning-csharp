namespace Luotao.Test.Books.ICS7._14._11
{
    /// <summary>
    /// 14.11 invoking delegates with return values
    /// </summary>
    public class T01
    {
        private int F01()
        {
            return 1;
        }

        private int F02()
        {
            return 2;
        }

        /// <summary>
        /// 如果 delegate 有返回类型, 则它的返回值为最后一个方法的返回值, 其他方法的返回值被忽略了.
        /// </summary>
        [Fact]
        public void _01()
        {
            Func<int> func01 = F01;
            func01 += F02;

            Assert.Equal(2, func01.Invoke());
        }
    }
}
