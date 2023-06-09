using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DALLayer;
namespace ReservationSystemService
{
    public class BookService
    {
        private readonly BookDAO bookDAO;

        public BookService (BookDAO bookDAO)
        {
            this.bookDAO = bookDAO;
        }   
        public List<Book> GetAll()
        {
            return bookDAO.GetAll();    
        }
        public Book GetById(int BookId)
        {
            return bookDAO.GetById(BookId);
        }
        public List<Book> GetByAurthor(string aurthorName)
        {
            return bookDAO.GetByAuthor(aurthorName);
        }
    }
}
