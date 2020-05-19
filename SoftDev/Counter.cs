namespace SoftDev
{
    public class Counter
    {
        private int value;

        public Counter()
        {
            value = 0;
        }

        public int GetValue()
        {
            value += 1;
            return value;
        }
    }
}
