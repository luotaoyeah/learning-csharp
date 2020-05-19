namespace Luotao.Lib.Books.ICS7._18._06
{
    public static class ExtendHolder
    {
        //----------------------------------------------------------------------------------------------------
        // extionsion method 可以定义成 generic method
        //----------------------------------------------------------------------------------------------------
        public static T F02<T>(this Holder holder, T t)
        {
            return t;
        }
    }
}
