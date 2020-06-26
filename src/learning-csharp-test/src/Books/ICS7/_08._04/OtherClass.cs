using System;

namespace Luotao.Test.Books.ICS7._08._04
{
    /// <summary>
    /// 子类.
    /// </summary>
    public class OtherClass : SomeClass
    {
        /// <summary>
        /// 子类成员跟父类成员同名, 则子类成员会隐藏父类成员.
        /// 此时应该使用 new 关键字, 告诉编译器我们是特意隐藏的, 否则会有编译警告.
        /// </summary>
        public new string Field1 = "OtherClass.Field1";

        public new void Method01(string value)
        {
            Console.WriteLine($"OtherClass.Method1: {value}");
        }
    }
}
