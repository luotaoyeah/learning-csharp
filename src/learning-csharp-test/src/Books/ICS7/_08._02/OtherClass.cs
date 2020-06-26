using System;

namespace Luotao.Test.Books.ICS7._08._02
{
    /// <summary>
    /// 子类.
    /// </summary>
    public class OtherClass : SomeClass
    {
        public string Field2 = "derived class field";

        public void Method02(string value)
        {
            Console.WriteLine($"Derived class -- Method2: {value}");
        }
    }
}
