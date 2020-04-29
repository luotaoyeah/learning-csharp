using System;
using System.Collections;

namespace LT.BOOK.ICS7._19._03
{
    public class ColorEnumerator : IEnumerator
    {
        private string[] Colors;
        private int position = -1;

        public ColorEnumerator(string[] theColors)
        {
            Colors = new string[theColors.Length];
            for (var i = 0; i < theColors.Length; i++)
            {
                Colors[i] = theColors[i];
            }
        }

        public bool MoveNext()
        {
            if (position < Colors.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = -1;
        }


        public object Current
        {
            get
            {
                if (position < 0 || position >= Colors.Length)
                {
                    throw new InvalidOperationException();
                }

                return Colors[position];
            }
        }


        public void Dispose()
        {
        }
    }
}
