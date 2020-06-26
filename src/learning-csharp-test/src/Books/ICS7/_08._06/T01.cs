using Xunit;

namespace Luotao.Test.Books.ICS7._08._06
{
    /// <summary>
    /// 8.6 using references to a base class
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var derived = new MyDerivedClass();
            derived.Print();

            // 父类变量指向子类对象, 通过父类变量只能访问父类成员
            MyBaseClass mybc = derived;
            mybc.Print();
        }
    }
}
