namespace LT.LIB.BOOK.ICS7._08._06._03
{
    public class MyBaseClass
    {
        //----------------------------------------------------------------------------------------------------
        // 除了 method 可以使用 virtual/override 进行覆写之外，property/indexer/event 也可以，
        //----------------------------------------------------------------------------------------------------

        public virtual int P01 => 1;

        public virtual int this[int index] => 1;
    }
}
