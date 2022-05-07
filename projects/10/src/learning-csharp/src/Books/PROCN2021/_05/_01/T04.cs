namespace Luotao.LearningCsharp.Test.Books.PROCN2021._05._01
{
    namespace _04
    {
        /// <summary>
        /// 5.1.4. the is and as operators
        /// </summary>
        public class T04
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T04(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                C02 c02 = new();
                C01 c01 = c02;
                object c03 = new C03();

                Assert.True(c01 is C02);
                Assert.False(c03 is C01);

                // as 转换类型失败时会返回 null
                Assert.Null(c03 as C01);
                Assert.NotNull(c01 as C02);
            }
        }

        class C01
        {
        }

        class C02 : C01
        {
        }

        class C03
        {
        }
    }
}
