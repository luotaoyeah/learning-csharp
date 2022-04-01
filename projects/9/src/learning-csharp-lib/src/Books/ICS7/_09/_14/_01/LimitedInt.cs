namespace Luotao.Lib.Books.ICS7._09._14._01
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
                    theValue = MinValue;
                else if (value > MaxValue)
                    theValue = MaxValue;
                else
                    theValue = value;
            }
        }

        //----------------------------------------------------------------------------------------------------
        // 自定义显式类型转换（explicit conversion）的转换方式，
        // 不能同时定义隐式类型转换和显式类型转换，
        //----------------------------------------------------------------------------------------------------
        public static explicit operator int(LimitedInt limitedInt)
        {
            return limitedInt.theValue;
        }

        public static explicit operator LimitedInt(int i)
        {
            var limitedInt = new LimitedInt { TheValue = i };
            return limitedInt;
        }
    }
}
