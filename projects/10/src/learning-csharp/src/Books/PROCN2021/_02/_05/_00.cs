namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._05
{
    // 在 namespace 里面也可以使用 using
    using A.B.C.D.E;

    // 给 namespace 起一个 alias
    using ABCD = A.B.C.D;

    /// <summary>
    /// 2.5. organization with namespaces
    /// </summary>
    public class _00
    {
        [Fact]
        public void _01()
        {
            // 使用完整的 namespace
            var f01 = new A.B.C.D.E.F();
            Assert.Equal(f01.X, 0);
        }
    }

    /// <summary>
    /// 2.5.1 the using directive
    /// </summary>
    public class _01
    {
        [Fact]
        public void _02()
        {
            // using A.B.C.D.E;
            var f02 = new F();

            // using ABCD = A.B.C.D;
            var f03 = new ABCD.E.F();
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
