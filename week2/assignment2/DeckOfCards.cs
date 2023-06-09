namespace assignment2
{
    internal class DeckOfCards
    {
        private List<PlayingCard> deck;
        public DeckOfCards()
        {
            deck = new List<PlayingCard>();
            InitCards();
        }
        public void InitCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int j = 2; j <= 14; j++)
                {
                    deck.Add(new PlayingCard(j, suit));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int Num1 = random.Next(0, deck.Count);
                int Num2 = random.Next(0, deck.Count);

                PlayingCard temp = deck[Num1];
                deck[Num1] = deck[Num2];
                deck[Num2] = temp;
            }
        }
        public void Print()
        {
            foreach (PlayingCard card in deck)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
