using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._06._04;

/// <summary>
/// 5.6.4. defining indexers
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var c01 = new Person();
        c01.Children.Add(new Person { Name = "luotao" });
        c01.Children.Add(new Person { Name = "owen" });

        Assert.Equal("luotao", c01.Children[0].Name);
        Assert.Equal("owen", c01.Children[1].Name);

        Assert.Equal("luotao", c01[0].Name);
        Assert.Equal("owen", c01["1"].Name);

        c01[1] = new() { Name = "luotao" };
        Assert.Equal("luotao", c01[1].Name);
    }

    [Fact]
    public void _02()
    {
        var c01 = new Person { Children = new() { new() } };
        Assert.Equal("Unknown", c01[0, 0].Name);
    }
}
