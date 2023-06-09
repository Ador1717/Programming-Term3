namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            deck.Shuffle();
            deck.Print();

        }
    }
}