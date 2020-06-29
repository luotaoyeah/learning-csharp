namespace Luotao.Test.Books.ICS7._08._06._01
{
    /// <summary>
    /// 8.6.1 virtual and override methods
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var derived = new MyDerivedClass();
            derived.Print();

            // 父类变量指向子类对象, 通过父类变量只能访问父类成员,
            // 但是如果这个成员在父类是标记为 virtual, 在子类是标记为 override, 则此时访问的是子类成员.
            MyBaseClass mybc = derived;
            mybc.Print();
        }
    }
}
