namespace Luotao.Test.Books.CS10NET6._05._08._03;

public record ImmutableAnimal01
{
    public ImmutableAnimal01(string? name, string? species)
    {
        Name = name;
        Species = species;
    }

    public string? Name { get; init; }

    public string? Species { get; init; }

    public void Deconstruct(out string? name, out string? species)
    {
        name = Name;
        species = Species;
    }
}
