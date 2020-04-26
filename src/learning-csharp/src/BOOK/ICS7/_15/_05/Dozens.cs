namespace LT.BOOK.ICS7._15._05
{
    public class Dozens
    {
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += () => DozensCount++;
        }

        public int DozensCount { get; private set; }
    }
}
