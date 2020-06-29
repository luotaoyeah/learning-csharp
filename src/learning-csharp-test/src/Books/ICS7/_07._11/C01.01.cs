namespace Luotao.Test.Books.ICS7._07._11
{
    public class C0101
    {
        [Fact]
        public void _01()
        {
            var c0101 = new Lib.Books.ICS7._07._11.C0101();
            Assert.Equal(18, c0101.Age);
            Assert.Equal("luotao", c0101.Name);

            var c0102 = new Lib.Books.ICS7._07._11.C0101(20);
            Assert.Equal(20, c0102.Age);
            Assert.Equal("luotao", c0102.Name);

            var c0103 = new Lib.Books.ICS7._07._11.C0101(20, "owen");
            Assert.Equal(20, c0103.Age);
            Assert.Equal("owen", c0103.Name);
        }
    }
}
