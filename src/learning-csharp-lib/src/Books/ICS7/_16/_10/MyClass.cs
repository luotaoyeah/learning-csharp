namespace Luotao.Lib.Books.ICS7._16._10
{
    public class MyClass : IMyInterface01, IMyInterface02
    {
        //----------------------------------------------------------------------------------------------------
        // 可以在 method 名称前面加上 interface 名称作为限定符，
        // 表示这是一个 explicit interface member implementation，
        // 实现的是该 interface 中的这个 method，
        //----------------------------------------------------------------------------------------------------
        int IMyInterface01.F01()
        {
            return 1;
        }

        int IMyInterface02.F01()
        {
            return 2;
        }
    }
}
