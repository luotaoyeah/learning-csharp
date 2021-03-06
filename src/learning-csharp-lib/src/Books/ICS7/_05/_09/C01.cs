namespace Luotao.Lib.Books.ICS7._05._09
{
    /// <summary>
    ///     5.9 accessing members from inside the class
    /// </summary>
    public class C01
    {
        //----------------------------------------------------------------------------------------------------
        // 默认的访问修饰符是 private
        //----------------------------------------------------------------------------------------------------
        private readonly int X = 6;
        private readonly int Y = 6;

        private int GetX()
        {
            return X;
        }

        private int GetY()
        {
            return Y;
        }

        //----------------------------------------------------------------------------------------------------
        // 在类里面，所有的 member 都可以相互访问，无论是 private 还是 public，
        //----------------------------------------------------------------------------------------------------
        public int Sum()
        {
            return GetX() + GetY();
        }
    }
}
