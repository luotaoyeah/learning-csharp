namespace Luotao.Test.Books.CS10NET6._05._08._01;

public class ImmutablePerson
{
    private string? firstName;

    public ImmutablePerson()
    {
    }

    public ImmutablePerson(string? firstName, string? lastName)
    {
        this.firstName = firstName;
        LastName = lastName;
    }

    /// <summary>
    /// 使用 init 替换 set, 表示该 property 是一个 init-only property,
    /// 只能在 constructor / init accessor / object-initializer 中被赋值.
    /// </summary>
    public string? FirstName
    {
        get => firstName;

        // 在 init accessor 中可以对 init-only property 赋值
        init => firstName = value;
    }

    public string? LastName { get; init; }
}
