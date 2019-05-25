namespace LT.BOOK.ICS7.C05.C0504
{
    /// <summary>
    /// 5.4.1. Fields
    /// </summary>
    public class C050401
    {
        // 如何声明一个字段(field) ?
        // field naming convention 使用 PascalCase

        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        public string Name;

        public C050401(string name)
        {
            Name = name;
        }
    }
}