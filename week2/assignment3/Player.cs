namespace assignment3
{
    class Player
    {
        public string name;
        public List <PlayingCard>Cards = new List<PlayingCard>();

        public Player(string name)
        { 
            this.name = name;
        }
       
        public void AddCard(PlayingCard card)
        {
            Cards.Add(card);
        }
        public PlayingCard GetNextCard()
        {
            if (Cards.Count() == 0)
            {
                throw new Exception();
            }
            PlayingCard Nxtcard = Cards[0];
            Cards.RemoveAt(0);
            return Nxtcard;
        }
      
    }
}
