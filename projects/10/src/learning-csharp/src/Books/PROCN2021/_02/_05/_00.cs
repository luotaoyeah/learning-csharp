namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._05
{
    /// <summary>
    /// 2.5. organization with namespaces
    /// </summary>
    public class _00
    {
        private readonly ITestOutputHelper testOutputHelper;

        public _00(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            var f = new A.B.C.D.E.F();
            Assert.Equal(f.X, 0);
        }
    }

    // namespace 可以嵌套,
    namespace A
    {
        namespace B
        {
            // 嵌套的 namespace 可以写在一行, 用点分隔,
            namespace C.D.E
            {
                class F
                {
                    public int X = 0;
                }
            }
        }
    }
}
