namespace Luotao.Lib.Books.ICS7._08._14
{
    public static class ExtendMyData
    {
        //----------------------------------------------------------------------------------------------------
        // extension method 必须定义在 static class 中，
        // extension method 必须是一个 public static method，
        // 第一个参数为要进行扩展的 class，在它前面加上关键字 this，
        //----------------------------------------------------------------------------------------------------
        public static double Average(this MyData myData)
        {
            return myData.Sum() / 3;
        }
    }
}
