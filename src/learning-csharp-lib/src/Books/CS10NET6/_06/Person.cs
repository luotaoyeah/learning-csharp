using System.Collections.Generic;

namespace Luotao.Lib.Books.CS10NET6._06;

public class Person
{
    public List<Person> Children = new();
    public string? Name;

    public static Person Procreate(Person p1, Person p2)
    {
        var person = new Person
        {
            Name = $"baby of {p1.Name} and {p2.Name}"
        };

        p1.Children.Add(person);
        p2.Children.Add(person);

        return person;
    }

    /// <summary>
    /// operator 本质上是一个 static method.
    /// </summary>
    /// <param name="father">父亲.</param>
    /// <param name="mother">母亲.</param>
    /// <returns></returns>
    public static Person operator *(Person father, Person mother)
    {
        return Procreate(father, mother);
    }
}
