using Luotao.Lib.Books.CS10NET6._06;

namespace Luotao.Test.Books.CS10NET6._06._02._02;

/// <summary>
/// 6.2.2. implementing functionality using operators
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var father = new Person { Name = "张三" };
        var mother = new Person { Name = "李四" };

        var child01 = Person.Procreate(father, mother);
        Assert.Equal("baby of 张三 and 李四", child01.Name);

        var child02 = father * mother;
        Assert.Equal("baby of 张三 and 李四", child02.Name);
    }
}
