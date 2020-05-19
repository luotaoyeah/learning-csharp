using System.Collections;

namespace LuotaoYeah.Lib.Books.ICS7._19._03
{
    public class Spectrum : IEnumerable
    {
        private readonly string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }
    }
}
