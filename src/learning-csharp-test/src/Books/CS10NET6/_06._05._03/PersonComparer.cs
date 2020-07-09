using Luotao.Lib.Books.CS10NET6._06;

namespace Luotao.Test.Books.CS10NET6._06._05._03;

/// <summary>
/// 实现 IComparer 接口, 以第三方的身份来比较某个类型.
/// </summary>
public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        return -x.CompareTo(y);
    }
}
