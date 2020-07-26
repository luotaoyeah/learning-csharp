namespace Luotao.Test.Books.CS10NET6._05._08._02;

/// <summary>
/// record(record class) 是 reference 类型, record struct 是 value 类型.
/// </summary>
public record ImmutableVehicle
{
    public string? Color { get; init; }

    /// <summary>
    /// record 的 property 不一定非得是 init-only property.
    /// </summary>
    public int Wheels { get; set; }
}
