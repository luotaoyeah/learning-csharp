using System;

namespace Luotao.Test.Books.ICS7._08._05
{
    /// <summary>
    /// 子类.
    /// </summary>
    public class OtherClass : SomeClass
    {
        public new string Field1 = "OtherClass.Field1";

        /// <summary>
        /// 使用 base.XXX 访问父类中被隐藏的成员.
        /// </summary>
        public void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }
    }
}
