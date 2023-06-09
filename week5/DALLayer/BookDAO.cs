using ModelLayer;
using System.Configuration;
using System.Data.SqlClient;
namespace DALLayer
{
    public class BookDAO
    {
        private readonly SqlConnection connection;

        public BookDAO()
        {
            string connstring = ConfigurationManager
                .ConnectionStrings["SomerenDatabase"]
                .ConnectionString;
            connection = new SqlConnection(connstring);
        }
        public List<Book> GetAll()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            connection.Close();
            return books;
        }
        public Book GetById(int BookId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Books WHERE Id = @Id", connection);

            cmd.Parameters.AddWithValue("@Id", BookId);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
            {
                book = ReadBook(reader);
            }
            reader.Close();
            connection.Close();

            return book;
        }
        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string author = (string)reader["Author"];
            string title = (string)reader["Title"];

            return new Book(id, title, author);
        }
        public List<Book> GetByAuthor(string authorName)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Author = @Author", connection);

            cmd.Parameters.AddWithValue("@Author", authorName);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = ReadBook(reader);
                books.Add(book);
            }
            reader.Close();
            connection.Close();
            return books;
        }
    }
}