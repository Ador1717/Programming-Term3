namespace assignment1
{
    public class Book : BookStoreItem
    {
        public string Author { get; }
        public Book(string title, string author, double price, int count) : base(title, price, count)
        {
            this.Author = author;
        }
        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price:.00} ({Count}x)");
        }
    }
}
