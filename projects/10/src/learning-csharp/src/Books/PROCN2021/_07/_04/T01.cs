namespace Luotao.LearningCsharp.Test.Books.PROCN2021._07._04
{
    namespace _01
    {
        /// <summary>
        /// 7.4. events
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
                C01 c01 = new C01();

                // sender 表示发起事件的对象, 在这儿就是 c01
                c01.OnClick += (sender, x) =>
                {
                    Assert.Equal(c01, sender);
                    testOutputHelper.WriteLine("000:{0}", x);
                };
                c01.OnClick += (_, x) => { testOutputHelper.WriteLine("111:{0}", x); };

                c01.Emit(6);
                c01.Emit(9);
            }
        }

        public class C01
        {
            /// <summary>
            /// 定义事件.
            /// event 是一种特殊的 delegate, 特殊在哪儿? 只能注册(+=)和退订(-=)事件监听函数.
            /// </summary>
            public event EventHandler<int>? OnClick;

            // 显式地声明 event 的 add/remove
            public event EventHandler<int>? OnClick02
            {
                add => onClick02 += value;
                remove => onClick02 -= value;
            }

            private EventHandler<int>? onClick02;

            /// <summary>
            /// 发起事件.
            /// </summary>
            public void Emit(int x)
            {
                OnClick?.Invoke(this, x);
            }
        }
    }
}
