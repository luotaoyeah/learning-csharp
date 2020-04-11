namespace LT.BOOK.ICS7._07._10
{
    /// <summary>
    /// 7.10.2 a property example
    /// 7.10.3 using a property
    /// </summary>
    public class C0102
    {
        //----------------------------------------------------------------------------------------------------
        // property 本质上是一个 function member，它包含两个 accessor：get/set，
        // get 用来读该 property 的值，
        // set 用来写该 property 的值，在 set 中可以访问 value 参数，
        //
        // 一般来说 property 都会对应使用一个 field 来存取真正的数据，
        //----------------------------------------------------------------------------------------------------

        private int i01;

        public int I01
        {
            get { return i01; }
            set { i01 = value; }
        }
    }
}
