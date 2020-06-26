using System;

namespace Luotao.Test.Books.ICS7._08._02
{
    /// <summary>
    /// 父类.
    /// </summary>
    public class SomeClass
    {
        public string Field1 = "base class field";

        public void Method01(string value)
        {
            Console.WriteLine($"Base class -- Method1: {value}");
        }
    }
}
