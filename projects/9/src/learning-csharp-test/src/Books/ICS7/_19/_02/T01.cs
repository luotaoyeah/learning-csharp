using System.Collections;

namespace Luotao.Test.Books.ICS7._19._02
{
    /// <summary>
    /// 19.2 the IEnumerator interface
    /// </summary>
    public class T01
    {
        /// <summary>
        /// foreach 的内部原理如下.
        /// Array 实现了 IEnumerable 接口的 GetEnumerator() 方法,
        /// 返回一个 IEnumerator 对象,
        /// 调用 IEnumerator.MoveNext() 方法移动当前指向的元素, 通过 IEnumerator.Current 属性访问当前元素.
        /// 当 MoveNext() 返回 false 时, 表示已经移动到最后一个元素的后面, 所有元素已经遍历完毕.
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };

            IEnumerator enumerator = arr01.GetEnumerator();

            Assert.True(enumerator.MoveNext());
            Assert.Equal(1, enumerator.Current);

            Assert.True(enumerator.MoveNext());
            Assert.Equal(2, enumerator.Current);

            Assert.True(enumerator.MoveNext());
            Assert.Equal(3, enumerator.Current);

            Assert.False(enumerator.MoveNext());
        }
    }
}
