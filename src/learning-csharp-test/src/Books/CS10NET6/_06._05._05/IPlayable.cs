namespace Luotao.Test.Books.CS10NET6._06._05._05;

public interface IPlayable
{
    void Play();

    /// <summary>
    /// 接口方法可以包含默认实现, 这样的话, 实现该接口的类就可以不用实现这个方法.
    /// 如果类没有实现这个方法, 则类也是不能够访问这个方法的.
    ///
    /// 这个特性的主要用途:
    ///   后期给接口添加新的方法时, 给它一个默认实现, 这样的话, 原来实现该接口的类就不受影响.
    /// </summary>
    void Pause()
    {
        Console.WriteLine($"我是接口方法 {nameof(Pause)}() 的默认实现");
    }
}
