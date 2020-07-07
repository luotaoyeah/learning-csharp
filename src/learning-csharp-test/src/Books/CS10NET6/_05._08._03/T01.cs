namespace Luotao.Test.Books.CS10NET6._05._08._03;

/// <summary>
/// 5.8.3. positional data members in records
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var (name, species) = new ImmutableAnimal01("X", "Y");

        Assert.Equal("X", name);
        Assert.Equal("Y", species);
    }

    [Fact]
    public void _02()
    {
        var (name, species) = new ImmutableAnimal02("X", "Y");

        Assert.Equal("X", name);
        Assert.Equal("Y", species);
    }
}
