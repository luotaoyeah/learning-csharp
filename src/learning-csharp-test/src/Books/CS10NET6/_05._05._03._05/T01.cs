namespace Luotao.Test.Books.CS10NET6._05._05._03
{
    /// <summary>
    ///     5.5.3 defining indexers
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
            var c01 = new C01();
            c01.Children.Add(new C01 { Name = "luotao" });
            c01.Children.Add(new C01 { Name = "owen" });

            Assert.Equal("luotao", c01.Children[0].Name);
            Assert.Equal("owen", c01.Children[1].Name);

            Assert.Equal("luotao", c01[0].Name);
            Assert.Equal("owen", c01["1"].Name);
        }

        [Fact]
        public void _02()
        {
            var c01 = new C01();
            Assert.Equal(9, c01[0, 0]);
        }
    }

    /// <summary>
    ///     indexer 是一种特殊的 property,
    ///     indexer 声明的不是 property name, indexer 声明的是 index type.
    /// </summary>
    public class C01
    {
        public List<C01> Children = new();
        public string? Name;

        public C01 this[string index] => Children[int.Parse(index)];

        public C01 this[int index] => Children[index];

        /// <summary>
        ///     可以定义多位索引.
        /// </summary>
        /// <param name="x">第一位索引</param>
        /// <param name="y">第二位索引</param>
        public int this[int x, int y] => 9;
    }
}
