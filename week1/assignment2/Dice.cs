namespace assignment2
{
    internal class Dice
    {
        public int value;
        Random rnd;
        public Dice(Random random)
        {
            rnd = random;
        }
        public void Throw()
        {
            value = rnd.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write($"{value,3}");
        }
    }
}
