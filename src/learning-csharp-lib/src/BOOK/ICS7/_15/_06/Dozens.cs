namespace LT.LIB.BOOK.ICS7._15._06
{
    public class Dozens
    {
        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += (_, _) => DozensCount++;
        }

        public int DozensCount { get; private set; }
    }
}
