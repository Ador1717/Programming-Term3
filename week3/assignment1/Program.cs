using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            BookStore store = new BookStore();

            Book type1 = new Book("Dracula", "Bram Stoker", 15.00, 5);
            Book type2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50, 5);
            Magazine type3 = new Magazine("Time", DayOfWeek.Friday, 3.90, 10);
            Magazine type4 = new Magazine("Donald Duck", DayOfWeek.Thursday, 2.50, 8);
            Book type5 = new Book("The hobbit", "J.R.R. Tolkien", 12.50, 4);

            store.Add(type1);
            store.Add(type2);
            store.Add(type3);
            store.Add(type4);
            store.Add(type5);

            store.PrintCompleteStock();
        }
    }
}