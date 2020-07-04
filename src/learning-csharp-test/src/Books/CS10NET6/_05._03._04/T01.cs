using Luotao.Lib.Books.CS10NET6._05;

namespace Luotao.Test.Books.CS10NET6._05._03._04;

/// <summary>
/// 5.3.4. storing a value using an enum type
/// </summary>
public class T01
{
    /// <summary>
    /// enum 的元素默认是 int 类型, 因此 enum 是值类型, 它的默认值为 0.
    /// </summary>
    [Fact]
    public void _01()
    {
        var person = new Person();
        Assert.Equal(0, (int)person.Favorite);
        Assert.Equal(0, (int)default(WondersOfTheAncientWorld));
    }

    /// <summary>
    /// 可以将 int 值转换为 enum 值, 即使该 int 值无法真正对应该 enum 的任何元素.
    /// </summary>
    [Fact]
    public void _02()
    {
        var person = new Person();

        // 3 对应了 WondersOfTheAncientWorld.D
        person.Favorite = (WondersOfTheAncientWorld)3;
        Assert.Equal("D", person.Favorite.ToString());

        // 9 无法对应任何枚举元素
        person.Favorite = (WondersOfTheAncientWorld)9;
        Assert.Equal("9", person.Favorite.ToString());
    }
}
