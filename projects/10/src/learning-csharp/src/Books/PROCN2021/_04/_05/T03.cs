namespace Luotao.LearningCsharp.Test.Books.PROCN2021._04._05
{
    namespace _03
    {
        /// <summary>
        /// 4.5.3. explicit and implicit implemented interfaces
        /// </summary>
        public class T03
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T03(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void _01()
            {
                var c01 = new C01();

                Assert.Equal(6, c01.F01());
                Assert.Equal(6, ((I01)c01).F01());
                Assert.Equal(6, ((I02)c01).F01());

                Assert.Equal(8, ((I01)c01).F02());
                Assert.Equal(88, ((I02)c01).F02());
            }
        }

        interface I01
        {
            public int F01();
            public int F02();
        }

        interface I02
        {
            public int F01();
            public int F02();
        }

        class C01 : I01, I02
        {
            // implicit implementation
            public int F01()
            {
                return 6;
            }

            // explicit implementation,
            // 不能使用 access modifier,
            int I01.F02()
            {
                return 8;
            }

            // explicit implementation
            int I02.F02()
            {
                return 88;
            }
        }
    }
}
