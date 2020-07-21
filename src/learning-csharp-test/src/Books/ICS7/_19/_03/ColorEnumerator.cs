using System.Collections;

namespace Luotao.Test.Books.ICS7._19._03;

public class ColorEnumerator : IEnumerator
{
    private string[] Colors;
    private int Position = -1;

    public ColorEnumerator(string[] colors)
    {
        Colors = new string[colors.Length];
        for (var i = 0; i < colors.Length; i++)
        {
            Colors[i] = colors[i];
        }
    }

    public bool MoveNext()
    {
        if (Position < Colors.Length - 1)
        {
            Position++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        Position = -1;
    }

    public object Current
    {
        get
        {
            if (Position == -1)
            {
                throw new InvalidOperationException();
            }

            if (Position >= Colors.Length)
            {
                throw new InvalidOperationException();
            }

            return Colors[Position];
        }
    }
}
