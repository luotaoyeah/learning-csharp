namespace LuotaoYeah.Lib.Books.ICS7._07._17
{
    /// <summary>
    ///     7.17 access modifiers on accessors
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // property/indexer 都属于 function member，它们都有两个 accessor（get/set），
        // 默认情况下，get/set 的 access level 跟它所属的 property/indexer 一样，
        // 在下面三个条件满足时，可以单独给 get/set 设置 access modifier：
        //   1. get/set 必须同时存在，
        //   2. 只能给其中一个（get 或者 set）设置 access modifier，
        //   3. get/set 的 access modifier 必须比 property/indexer 的更加严格
        //----------------------------------------------------------------------------------------------------

        public int P01 { get; private set; }

        protected int this[int index]
        {
            private get { return 0; }
            set { }
        }
    }
}
