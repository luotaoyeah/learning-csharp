using System;
using System.Collections.Generic;

namespace Luotao.Lib.Books.CS10NET6._06;

/// <summary>
/// 实现 IComparable 接口.
/// </summary>
public class Person : IComparable<Person>, IGamePlayer, IKeyHolder
{
    //----------------------------------------------------------------------------------------------------
    // EventHandler 是一个内置的 delegate 类型, 专门用来定义事件.
    //
    // delegate 类型签名加上 event 关键字, 表示这是一个特殊的 delegate,
    // 只能往里面添加/移除事件监听函数, 不能重新对它赋值.
    //----------------------------------------------------------------------------------------------------
    public event EventHandler? Shout;
    public int AngerLevel;
    public List<Person> Children = new();
    public string? Name;

    /// <inheritdoc />
    public int CompareTo(Person? other)
    {
        if (Name is null)
        {
            return 0;
        }

        return Name.CompareTo(other?.Name);
    }

    /// <summary>
    /// 隐式实现接口方法 (implicit implementation),
    /// 实现的多个接口中包含相同签名并且同名的方法, 则只有其中一个可以使用 implicit implementation 的方式,
    /// 其他的都必须使用 explicit implementation 的方式, 也就是必须在方法名前面加上接口名限定, 并且方法不能使用 public 限定.
    /// </summary>
    public void Lose()
    {
        Console.WriteLine($"{nameof(IGamePlayer)}.{nameof(Lose)}()");
    }

    /// <summary>
    /// 显式实现接口方法 (explicit implementation),
    /// 方法名前面必须加上接口名来显式指定我是实现的哪个接口的方法,
    /// 并且方法不能使用 public 限定.
    /// </summary>
    void IKeyHolder.Lose()
    {
        Console.WriteLine($"{nameof(IKeyHolder)}.{nameof(Lose)}()");
    }

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

    /// <summary>
    /// 计算阶乘.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static int Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException($"{nameof(n)} cannot be less than 0.");
        }

        return LocalFactorial(n);

        //----------------------------------------------------------------------------------------------------
        // local function 的作用域为当前 method
        //----------------------------------------------------------------------------------------------------
        int LocalFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            return x * LocalFactorial(x - 1);
        }
    }

    public void Poke()
    {
        AngerLevel++;

        if (AngerLevel >= 3)
        {
            // 发起一个事件
            Shout?.Invoke(this, EventArgs.Empty);
        }
    }
}
