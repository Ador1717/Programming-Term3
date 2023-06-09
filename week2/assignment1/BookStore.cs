namespace assignment1
{
    class BookStore
    {
        public List < TitlePrice> iteam ;
        
        public BookStore()
        {
             iteam = new List<TitlePrice>();    
        }
        public void Add( TitlePrice iteam)
        {
            this.iteam.Add(iteam);
        }
        public void PrintCompleteStock()
        {
            double totalPrice = 0;

            foreach (TitlePrice titlePrice in this.iteam)
            {
                titlePrice.Print();
                totalPrice += titlePrice.Price;
            }
            Console.WriteLine();
            Console.WriteLine($"Total sales price: {totalPrice:.00}");
        }
    }
}
