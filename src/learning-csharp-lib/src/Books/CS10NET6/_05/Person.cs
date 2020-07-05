using System;
using System.Collections.Generic;

namespace Luotao.Lib.Books.CS10NET6._05;

public class Person
{
    /// <summary>
    /// const field 隐式就是 static 的, 因此 static 和 const 不能同时使用.
    /// </summary>
    public const string Species = "Homo Sapiens";

    /// <summary>
    /// readonly field 可以是 instance field, 也可以是 static field.
    /// </summary>
    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    public List<Person> Children = new();
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld Favorite;
    public string? Name;

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string? initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
}
