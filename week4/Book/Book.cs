using System.Net.Mail;

namespace ReservationSystemModel
{
    public class Book
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Author;
        public string Title;

        public Book(int id, string title, string author) 
        { 
            Id = id;
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
        
    }
}