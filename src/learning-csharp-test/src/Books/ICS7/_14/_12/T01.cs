namespace Luotao.Test.Books.ICS7._14._12
{
    /// <summary>
    /// 14.12 invoking delegates with reference parameters
    /// </summary>
    public class T01
    {
        private void Add2(ref int x)
        {
            x += 2;
        }

        private void Add3(ref int x)
        {
            x += 3;
        }

        /// <summary>
        ///
        /// </summary>
        [Fact]
        public void _01()
        {
            MyDel del01 = Add2;
            del01 += Add3;
            del01 += Add2;

            int x = 5;

            del01(ref x);

            Assert.Equal(12, x);
        }
    }

    internal delegate void MyDel(ref int x);
}
