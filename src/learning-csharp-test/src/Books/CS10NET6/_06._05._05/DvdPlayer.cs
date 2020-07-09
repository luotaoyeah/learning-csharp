namespace Luotao.Test.Books.CS10NET6._06._05._05;

public class DvdPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine($"{nameof(DvdPlayer)}.{nameof(Play)}()");
    }
}
