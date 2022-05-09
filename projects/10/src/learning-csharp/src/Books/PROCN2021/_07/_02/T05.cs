namespace Luotao.LearningCsharp.Test.Books.PROCN2021._07._02
{
    namespace _05
    {
        /// <summary>
        /// 7.2.5. multicast delegates
        /// </summary>
        public class T05
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T05(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            /// <summary>
            /// <see cref="System.MulticastDelegate.GetInvocationList()"/>.
            /// </summary>
            [Fact]
            public void _01()
            {
                void F01()
                {
                    testOutputHelper.WriteLine("{0}()", nameof(F01));
                }

                void F02()
                {
                    testOutputHelper.WriteLine("{0}()", nameof(F02));
                }

                // 一个 delegate 可以包含多个方法
                Action del01 = F01;
                del01 += F02;

                Delegate[] delegates = del01.GetInvocationList();
                Assert.Equal(2, delegates.Length);

                foreach (Action f in delegates)
                {
                    f();
                }
            }
        }
    }
}
