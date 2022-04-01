namespace Luotao.Test.Books.CS10NET6._05._07._03
{
    /// <summary>
    /// 5.7.3. enhancements to pattern matching in C# 9 or later
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// C# 9/10 中的模式匹配的一些改进.
        /// </summary>
        [Fact]
        public void _01()
        {
            object[] objects =
            {
                new A { X = 1 },
                new A { X = 2 },
                new A { X = 3 },
                new B(),
                new C(),
            };

            foreach (object o in objects)
            {
                double value = o switch
                {
                    A a when (a.X == 1) => 1.1,
                    A { X: 2 } => 1.2,
                    // 多个模式匹配的条件合并到一起, 先判断是否是 A 类型, 然后判断其属性 X 是否大于等于 2
                    A { X: >= 2 } => 1.3,
                    B b => 2,
                    // 可以省略类型后面的变量名, 因为没有使用它
                    C => 3,
                    _ => 0,
                };

                testOutputHelper.WriteLine(value.ToString());
            }
        }
    }
}
