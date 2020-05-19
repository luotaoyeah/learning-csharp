using Xunit;

namespace Luotao.Test.Books.ICS7._07._13
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c01 = new Lib.Books.ICS7._07._13.C01();
            c01.age = 18;
            c01.Name = "luotao";
            Assert.Equal(18, c01.age);
            Assert.Equal("luotao", c01.Name);

            //----------------------------------------------------------------------------------------------------
            // 上面的对象初始化，可以使用下面的 object initializer 方式来完成，
            //----------------------------------------------------------------------------------------------------

            var c02 = new Lib.Books.ICS7._07._13.C01 { age = 18, Name = "luotao" };
            Assert.Equal(18, c02.age);
            Assert.Equal("luotao", c02.Name);
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // 如果 constructor 的参数为空，还可以省略小括号，
            //----------------------------------------------------------------------------------------------------
            var c01 = new Lib.Books.ICS7._07._13.C01 { age = 18, Name = "luotao" };
            Assert.Equal(18, c01.age);
            Assert.Equal("luotao", c01.Name);
        }
    }
}
