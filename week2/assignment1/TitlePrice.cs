namespace assignment1
{
    public abstract class TitlePrice
    {
        public string Title;
        public double Price;

        public TitlePrice(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }
        public abstract void Print();       
    }
}
