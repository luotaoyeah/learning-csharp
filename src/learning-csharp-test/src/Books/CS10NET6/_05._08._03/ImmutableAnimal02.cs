namespace Luotao.Test.Books.CS10NET6._05._08._03;

/// <summary>
/// 跟 ImmutableAnimal01 是等价的, 编译器会帮我们生成相关代码.
/// 这种语法称之为 positional record.
/// 生成的 constructor 称之为 primary constructor.
/// </summary>
/// <param name="Name"></param>
/// <param name="Species"></param>
public record ImmutableAnimal02(string? Name, string? Species);
