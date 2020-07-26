namespace Luotao.Test.Books.CS10NET6._05._03._05;

/// <summary>
/// enum 元素默认是 int 类型, 这儿我们使用了 byte 类型, 因为大小已经足够.
/// </summary>
[Flags]
public enum WondersOfTheAncientWorld : byte
{
    A = 0b_0000_0001,
    B = 0b_0000_0010,
    C = 0b_0000_0100,
    D = 0b_0000_1000,
    E = 0b_0001_0000,
    F = 0b_0010_0000,
    G = 0b_0100_0000,
}
