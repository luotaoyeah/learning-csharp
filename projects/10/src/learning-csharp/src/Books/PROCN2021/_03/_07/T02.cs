namespace Luotao.LearningCsharp.Test.Books.PROCN2021._03._07
{
    namespace _02
    {
        /// <summary>
        /// 3.7.2. in parameters
        /// </summary>
        public class T02
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T02(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                // in 跟 ref 的相同点: 都是 pass by reference,
                // in 跟 ref 的不同点: 不能在方法内修改该参数, 相当于 readonly ref
                void F01(in S01 s01)
                {
                    // CS8332
                    // s01.X = 8;
                }
            }
        }

        struct S01
        {
            public int X { get; set; }
        }
    }
}
