namespace LT.LIB.BOOK.ICS7._09._15._01
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
        // 运算符重载（operator overloading）不能改变该 operator 的 priority/associativity 等等，
        // 只能重新定义这个运算符用在自定义的 class/struct 上时，要如何处理逻辑，
        //----------------------------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------------------------
        // 重载一元运算符，唯一参数的类型必须为当前 class/struct
        //----------------------------------------------------------------------------------------------------
        public static LimitedInt operator -(LimitedInt x)
        {
            var limitedInt = new LimitedInt { TheValue = 0 };
            return limitedInt;
        }

        public static LimitedInt operator -(LimitedInt x, LimitedInt y)
        {
            var limitedInt = new LimitedInt { TheValue = x.TheValue - y.TheValue };
            return limitedInt;
        }

        //----------------------------------------------------------------------------------------------------
        // 重载二元运算符，其中某个参数的类型必须为当前 class/struct
        //----------------------------------------------------------------------------------------------------
        public static LimitedInt operator +(LimitedInt x, double y)
        {
            var limitedInt = new LimitedInt { TheValue = x.TheValue + (int) y };
            return limitedInt;
        }
    }
}
