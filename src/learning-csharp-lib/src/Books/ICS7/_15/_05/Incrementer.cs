namespace LuotaoYeah.Lib.Books.ICS7._15._05
{
    // 定义 event 的 delegate 类型
    public delegate void Handler();

    public class Incrementer
    {
        // 定义一个 event member
        public event Handler CountedADozen;

        public void DoCount()
        {
            for (var i = 0; i < 100; i++)
                if (i % 12 == 0)
                    // 在合适的时机 raise 这个 event
                    CountedADozen?.Invoke();
        }
    }
}
