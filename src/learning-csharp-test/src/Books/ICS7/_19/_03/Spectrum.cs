using System.Collections;

namespace Luotao.Test.Books.ICS7._19._03;

public class Spectrum : IEnumerable
{
    private string[] Colors = { "RED", "BLUE", "YELLOW", "GREEN" };

    public IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(Colors);
    }
}
