namespace Luotao.Test.Books.ICS7._14._04
{
    /// <summary>
    /// 14.4 creating the delegate object
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            // 使用 new 创建一个 delegate 对象, 并且必须传入一个方法, 作为 invocation list 中的第一个方法.
            MyDel del = new MyDel(new C01().F01);

            // 直接将一个方法赋值给 delegate 对象, 实际上是一个语法糖, 跟上面的含义一样.
            del = C01.F02;

            // delegate 类型是引用类型.
            Assert.NotNull(del);
        }
    }

    delegate void MyDel(int p);

    class C01
    {
        public void F01(int x)
        {
        }

        public static void F02(int x)
        {
        }
    }
}
