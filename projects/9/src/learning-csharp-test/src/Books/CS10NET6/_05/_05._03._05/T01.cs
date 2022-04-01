namespace Luotao.Test.Books.CS10NET6._05._03._05;

/// <summary>
/// 5.3.5. storing multiple values using an enum type
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var person = new Person
        {
            BucketList = WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E
        };

        Assert.Equal((WondersOfTheAncientWorld)17, person.BucketList);
        Assert.Equal(17, (byte)person.BucketList);
        Assert.Equal("A, E", person.BucketList.ToString());
        Assert.Equal(WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E, person.BucketList);
    }

    [Fact]
    public void _02()
    {
        var person = new Person
        {
            // 直接将一个数字转换成枚举类型
            // 17 = 1 + 16 = WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E
            BucketList = (WondersOfTheAncientWorld)17
        };

        Assert.Equal(WondersOfTheAncientWorld.A | WondersOfTheAncientWorld.E, person.BucketList);
    }
}
