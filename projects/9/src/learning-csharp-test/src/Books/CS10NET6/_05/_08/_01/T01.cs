namespace Luotao.Test.Books.CS10NET6._05._08._01;

/// <summary>
/// 5.8.1. init-only properties
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        // 在 object-initializer 中可以对 init-only property 赋值
        var person01 = new ImmutablePerson
        {
            FirstName = "luo",
            LastName = "tao",
        };

        // 在 constructor 中可以对 init-only property 赋值
        var person02 = new ImmutablePerson("luo", "tao");

        // CS8852 init-only property 不能再被赋值
        // person01.FirstName = "owen";
    }
}
