#nullable enable
using System;

namespace LT.LIB.BOOK.ICS7._16._01._01
{
    public class MyClass : IComparable
    {
        public int TheValue;

        public int CompareTo(object? obj)
        {
            if (null != obj)
            {
                MyClass other = (MyClass) obj;
                return TheValue < other.TheValue ? -1 : TheValue > other.TheValue ? 1 : 0;
            }

            return 0;
        }

        public override string ToString()
        {
            return TheValue.ToString();
        }
    }
}
