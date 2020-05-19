using System.Collections.Generic;

namespace Luotao.Lib.Books.ICS7._19._08
{
    public class Spectrum
    {
        /// <summary>
        ///     除了 method 可以作为 iterator block 之外，property 的 get 也可以作为 iterator block，
        /// </summary>
        public IEnumerator<string> BlackAndWhite
        {
            get
            {
                yield return "black";
                yield return "gray";
                yield return "white";
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite;
        }
    }
}
