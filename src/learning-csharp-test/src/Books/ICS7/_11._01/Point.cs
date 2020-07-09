namespace Luotao.Test.Books.ICS7._11._01;

/// <summary>
/// struct 不能继承其他的 struct/class, 也不能被其他的 class/struct 继承.
/// struct 可以实现接口.
/// </summary>
public struct Point : IPoint
{
    public int X;
    public int Y;
}
