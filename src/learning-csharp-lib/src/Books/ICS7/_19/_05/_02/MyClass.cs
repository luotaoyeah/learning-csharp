using System.Collections.Generic;

namespace Luotao.Lib.Books.ICS7._19._05._02
{
    public class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite();
        }

        private IEnumerator<string> BlackAndWhite()
        {
            yield return "black";
            yield return "gray";
            yield return "white";
        }
    }
}
