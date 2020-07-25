using System;
using System.Linq;
using System.Threading.Tasks;

namespace P50;

public class Program
{
    public static async Task Main(string[] args)
    {
        var ctx = new P50DbContext();
        ctx.Books.Add(new Book() { Title = "000", Price = 99 });
        await ctx.SaveChangesAsync();
    }

    private static async Task CreatePerson()
    {
        P50DbContext ctx = new P50DbContext();

        ctx.Persons.Add(new Person() { Name = "luotao", Age = 18 });
        await ctx.SaveChangesAsync();
    }

    private static async Task UpdatePerson()
    {
        P50DbContext ctx = new P50DbContext();

        Person person = ctx.Persons.First();
        person.Name = "LUOTAO";

        await ctx.SaveChangesAsync();
    }

    private static void RetrievePerson()
    {
        P50DbContext ctx = new P50DbContext();

        foreach (Person person in ctx.Persons.Select(i => i))
        {
            Console.WriteLine(person.Name);
        }
    }

    private static void DeletePerson()
    {
        P50DbContext ctx = new P50DbContext();

        Person person = ctx.Persons.OrderBy(i => i.Name).Last();
        ctx.Persons.Remove(person);
        ctx.SaveChanges();
    }
}
