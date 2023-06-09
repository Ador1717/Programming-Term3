namespace assignment3
{
    class WarCardGame : CardGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public WarCardGame(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();

            bool firstPlayer = true;
            foreach (PlayingCard card in deck.deck)
            {

                if (firstPlayer)
                {
                    Player1.AddCard(card);
                }
                else
                {
                    Player2.AddCard(card);
                }
                firstPlayer = !firstPlayer;
            }
        }
        public bool EndOfGame()
        {
            if (Player1.Cards.Count == 0)
            {
                Console.WriteLine();
                Console.Write(Player2.name + " has won!");
                return true;
            }
            else if (Player2.Cards.Count == 0)
            {
                Console.WriteLine();
                Console.Write(Player1.name + "has won!");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void NextCard()
        {
            PlayingCard card1 = Player1.GetNextCard();
            PlayingCard card2 = Player2.GetNextCard();

            Console.WriteLine($"[{Player1.name}] {card1} - [{Player2.name}] {card2}");

            if (card1.Rank > card2.Rank)
            {
                Player1.AddCard(card1);
                Player1.AddCard(card2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Player1.name} got the cards");
                Console.ResetColor();
            }
            else if (card1.Rank < card2.Rank)
            {
                Player2.AddCard(card2);
                Player2.AddCard(card1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Player2.name} got the cards");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left: [{Player1.name}] {Player1.Cards.Count}x, [{Player2.name}] {Player2.Cards.Count}x");
            }
            Console.ResetColor();
        }
    }
}
