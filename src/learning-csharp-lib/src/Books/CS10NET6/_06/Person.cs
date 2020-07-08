using System;
using System.Collections.Generic;

namespace Luotao.Lib.Books.CS10NET6._06;

/// <summary>
/// 实现 IComparable 接口.
/// </summary>
public class Person : IComparable<Person>
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
