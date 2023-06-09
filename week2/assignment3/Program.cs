namespace assignment3
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
            Player Player1 = new Player("John");
            Player Player2 = new Player("Emma");
            WarCardGame war = new WarCardGame(Player1, Player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }
        }

    }
}