namespace LT.BOOK.ICS7._07._11
{
    /// <summary>
    /// 7.11.1 constructors with parameters
    /// </summary>
    public class C0101
    {
        //----------------------------------------------------------------------------------------------------
        // constructor 可以定义参数，constructor 可以重载
        //----------------------------------------------------------------------------------------------------

        public C0101()
        {
            Age = 18;
            Name = "luotao";
        }

        public C0101(int age)
        {
            Age = age;
            Name = "luotao";
        }

        public C0101(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; }
        public string Name { get; }
    }
}
