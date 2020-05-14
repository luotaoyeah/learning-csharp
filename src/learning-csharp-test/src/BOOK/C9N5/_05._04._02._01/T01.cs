using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._05._04._02._01
{
    /// <summary>
    /// 5.4.2.1 naming the fields of a tuple
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// </summary>
        [Fact]
        public void _01()
        {
            (string Name, int Number) fruit = C01.GetFruit();
            Assert.Equal("Apples", fruit.Name);
            Assert.Equal(5, fruit.Number);
        }
    }

    public class C01
    {
        /// <summary>
        /// 可以指定 tuple 的字段名称, 而不是用默认的 Item1/Item2/...
        /// </summary>
        /// <returns></returns>
        public static (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }
    }
}
