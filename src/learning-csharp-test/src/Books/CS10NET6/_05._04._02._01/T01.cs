using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._04._02._01
{
    /// <summary>
    ///     5.4.2.1 naming the fields of a tuple
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
            var fruit = C01.GetFruit();
            Assert.Equal("Apples", fruit.Name);
            Assert.Equal(5, fruit.Number);

            //----------------------------------------------------------------------------------------------------
            // 此时默认的字段名 Item1/Item2... 依然是可以用的.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("Apples", fruit.Item1);
            Assert.Equal(5, fruit.Item2);
        }
    }

    public class C01
    {
        /// <summary>
        ///     可以指定 tuple 的字段名, 而不是用默认的 Item1/Item2/...
        /// </summary>
        /// <returns></returns>
        public static (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }
    }
}
