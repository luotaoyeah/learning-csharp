namespace LT.LIB.BOOK.ICS7._07._16
{
    /// <summary>
    /// 7.16.4 declaring an indexer
    /// </summary>
    public class C0104
    {
        //----------------------------------------------------------------------------------------------------
        // indexer 类似 property，用来实现通过索引访问类的数据，
        //----------------------------------------------------------------------------------------------------

        public int X = 1;
        public int Y = 2;
        public int Z = 3;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: return -1;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;
                }
            }
        }
    }
}
