namespace assignment2
{
    internal class PlayingCard
    {
        public int Rank;
        public CardSuit CardSuit;

        public PlayingCard ( int rank, CardSuit cardSuit)
        {
            this.CardSuit = cardSuit;
            this.Rank = rank;
        }
        public override string ToString()
        {
            string rankStrings;

            if (Rank == 14)
            {
                rankStrings = "Ace";
            }
            else if (Rank == 11)
            {
                rankStrings = "Jack";
            }
            else if (Rank == 12)
            {
                rankStrings = "Queen";
            }
            else if (Rank == 13)
            {
                rankStrings = "King";
            }
            else
            {
                rankStrings= Rank.ToString();
            }
            return $"{rankStrings} of {CardSuit}";
        }
    }
}
