namespace LT.LIB.BOOK.ICS7._09._14
{
    public class LimitedInt
    {
        private const int MaxValue = 100;
        private const int MinValue = 0;

        private int theValue;

        public int TheValue
        {
            get => theValue;
            set
            {
                if (value < MinValue)
                {
                    theValue = MinValue;
                }
                else if (value > MaxValue)
                {
                    theValue = MaxValue;
                }
                else
                {
                    theValue = value;
                }
            }
        }

        //----------------------------------------------------------------------------------------------------
        // 自定义隐式类型转换（implicit conversion）的转换方式
        //----------------------------------------------------------------------------------------------------
        public static implicit operator int(LimitedInt limitedInt)
        {
            return limitedInt.theValue;
        }

        public static implicit operator LimitedInt(int i)
        {
            var limitedInt = new LimitedInt { TheValue = i };
            return limitedInt;
        }
    }
}
