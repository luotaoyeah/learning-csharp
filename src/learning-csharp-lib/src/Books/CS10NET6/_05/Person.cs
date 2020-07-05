using System;
using System.Collections.Generic;

namespace Luotao.Lib.Books.CS10NET6._05;

public class Person
{
    public List<Person> Children = new();
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld Favorite;
    public string? Name;
}
