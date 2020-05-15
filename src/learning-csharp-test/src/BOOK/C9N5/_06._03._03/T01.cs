using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._06._03._03
{
    /// <summary>
    ///     6.3.3 defining and handling events
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
            var c01 = new C01();

            //----------------------------------------------------------------------------------------------------
            // 注册两个事件处理函数.
            //----------------------------------------------------------------------------------------------------
            c01.OnClick += (sender, i) => { testOutputHelper.WriteLine($"handler 01: {i.ToString()}"); };
            c01.OnClick += (sender, i) => { testOutputHelper.WriteLine($"handler 02: {i.ToString()}"); };

            c01.Click();
            c01.Click();
        }
    }

    public class C01
    {
        private int count = 1;

        /// <summary>
        ///     某个字段的类型是 delegate, 前面再加上关键字 event, 这个字段就叫做一个 event.
        ///     所以 event 是一种特殊的 delegate, 在定义它的类的外部只能对这个 event 添加/移除事件处理函数,
        ///     不能直接对 event 进行赋值, 或者直接执行该 event.
        /// </summary>
        public event EventHandler<int>? OnClick;

        /// <summary>
        ///     触发一个事件, 实际上就是执行这个 event/delegate.
        /// </summary>
        public void Click()
        {
            OnClick?.Invoke(this, count++);
        }
    }
}
