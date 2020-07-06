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
    /// indexer 是一种特殊的 property.
    /// </summary>
    /// <param name="index"></param>
    public Person this[int index]
    {
        get => Children[index];
        set => Children[index] = value;
    }

    /// <summary>
    /// indexer 可以重载, 可以支持多个索引参数.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Person this[int x, int y]
    {
        get => Children[x];
        set => Children[x] = value;
    }

    public Person this[string index]
    {
        get => Children[int.Parse(index)];
        set => Children[int.Parse(index)] = value;
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

    /// <summary>
    /// 给参数指定默认值, 表示该参数是一个 optional parameter,
    /// 所有的 optional parameter 必须位于所有的 required parameter 后面.
    /// </summary>
    /// <param name="command"></param>
    /// <param name="number"></param>
    /// <param name="active"></param>
    /// <returns></returns>
    public string OptionalParameters(string command = "Run", double number = 0.0, bool active = true)
    {
        return $"{command}, {number}, {active}";
    }
}
