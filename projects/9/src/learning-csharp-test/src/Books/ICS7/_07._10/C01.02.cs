namespace Luotao.Test.Books.ICS7._07._10
{
    public class C0102
    {
        [Fact]
        public void _01()
        {
            var c0102 = new Lib.Books.ICS7._07._10.C0102();

            //----------------------------------------------------------------------------------------------------
            // 读写一个 property 跟读写一个 field 是一样的，它会自动调用 get/set，
            //----------------------------------------------------------------------------------------------------
            c0102.I01 = 6;
            Assert.Equal(6, c0102.I01);
        }
    }
}
