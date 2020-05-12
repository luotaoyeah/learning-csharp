namespace LT.LIB.BOOK.ICS7._18._09
{
    public class Simple<T, TR> : IMyInterface<TR>
    {
        public TR ReturnIt(TR inValue)
        {
            return inValue;
        }
    }
}
