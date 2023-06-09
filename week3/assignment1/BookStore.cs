namespace assignment1
{
    internal class BookStore
    {
        private List<BookStoreItem> iteam;

        public BookStore()
        {
            iteam = new List<BookStoreItem>();
        }
        public void Add(BookStoreItem iteam)
        {
            this.iteam.Add(iteam);
        }
        public void PrintCompleteStock()
        {
            double totalPrice = 0;

            foreach (BookStoreItem item in this.iteam)
            {
               item.Print();
                totalPrice += item.TotalPrice;
            }
            Console.WriteLine();
            Console.WriteLine($"Total sales price: {totalPrice:.00}");
        }
    }
}
