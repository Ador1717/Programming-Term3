namespace assignment1
{
    public abstract class BookStoreItem
    {
        private string title;
        private double price;
        private int count;

        public string Title
        {
            get { return title; }   
            set { title = value; }
        }
        public double Price
        {
            get { return price;}
            set { price = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public double TotalPrice
        {
            get { return price * count; }
        }

        public BookStoreItem(string title, double price, int count)
        {
            this.Title = title;
            this.Price = price;
            this.Count = count;
        }
        public abstract void Print();
    }
}
