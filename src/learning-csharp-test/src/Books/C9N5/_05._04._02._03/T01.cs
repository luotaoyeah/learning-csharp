using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._05._04._02._03
{
    /// <summary>
    ///     5.4.2.3 deconstructing tuples
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
            var person01 = C01.GetPerson();
            Assert.Equal("luotao", person01.Item1);
            Assert.Equal(18, person01.Item2);

            //----------------------------------------------------------------------------------------------------
            // 通过下面的方式, 可以指定 tuple 的字段名.
            //----------------------------------------------------------------------------------------------------
            (string name02, int age02) person02 = C01.GetPerson();
            Assert.Equal("luotao", person02.name02);
            Assert.Equal(18, person02.age02);

            //----------------------------------------------------------------------------------------------------
            // 将 tuple 的字段解构到不同的变量中.
            //----------------------------------------------------------------------------------------------------
            (string name03, var age03) = C01.GetPerson();
            Assert.Equal("luotao", name03);
            Assert.Equal(18, age03);

            //----------------------------------------------------------------------------------------------------
            // 将 tuple 的字段解构到已经存在的变量中.
            //----------------------------------------------------------------------------------------------------
            string name04;
            int age04;
            (name04, age04) = C01.GetPerson();
            Assert.Equal("luotao", name04);
            Assert.Equal(18, age04);
        }
    }

    public class C01
    {
        public static (string, int) GetPerson()
        {
            return ("luotao", 18);
        }
    }
}
