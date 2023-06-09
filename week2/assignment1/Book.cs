using System.Security.Cryptography.X509Certificates;

namespace assignment1
{
    public class Book : TitlePrice
    {
        public string Author;
        public Book(string title, string author, double price) : base(title, price)
        {
            this.Author = author;
        }
        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price:.00}");
        }
    }
}
