namespace LT.BOOK.ICS7._06._15
{
    /// <summary>
    /// 6.15 parameter arrays
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 使用 params 声明一个 parameter array，
        // 最多只能有一个 parameter array，且必须是最后一个 parameter，
        //----------------------------------------------------------------------------------------------------

        public static int Fn01(int x, params int[] arr)
        {
            int sum = 0;
            sum += x;


            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
