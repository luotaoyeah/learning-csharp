using System.Collections.Generic;

namespace LuotaoYeah.Lib.Books.ICS7._19._05._03
{
    public class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            IEnumerable<string> blackAndWhite = BlackAndWhite();
            return blackAndWhite.GetEnumerator();
        }

        private IEnumerable<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
