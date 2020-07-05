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

    /// <summary>
    /// 使用 tuple 类型作为方法的返回类型, 让方法返回多个数据.
    /// </summary>
    /// <returns>水果名称及其数量.</returns>
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    /// <summary>
    /// 任何类型, 只要实现了 Deconstruct() 方法, 就支持解构.
    /// </summary>
    /// <param name="name">姓名.</param>
    /// <param name="planet">星球.</param>
    public void Deconstruct(out string? name, out string planet)
    {
        name = Name;
        planet = HomePlanet;
    }
}
