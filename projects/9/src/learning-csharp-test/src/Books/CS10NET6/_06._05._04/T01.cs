using Luotao.Lib.Books.CS10NET6._06;

namespace Luotao.Test.Books.CS10NET6._06._05._04;

/// <summary>
/// 6.5.4. implicit and explicit interface implementations
/// </summary>
public class T01
{
    [Fact]
    public void _01()
    {
        var person = new Person();
        person.Lose();

        // 调用 explicit implementation 方式实现的接口方法时, 需要先转换为对应的接口类型
        ((IKeyHolder)person).Lose();
    }
}
