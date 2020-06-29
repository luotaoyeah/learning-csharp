namespace Luotao.Test.Books.ICS7._05._07
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c01 = new Lib.Books.ICS7._05._07.C01();
            var c02 = new Lib.Books.ICS7._05._07.C01();

            Assert.Equal(6, c01.I01);
            Assert.Equal(6, c02.I01);

            c01.I01 = 8;
            Assert.Equal(8, c01.I01);
            Assert.Equal(6, c02.I01);

            Assert.Equal(6, Lib.Books.ICS7._05._07.C01.S01);
        }
    }
}
