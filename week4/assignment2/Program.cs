using ReservationDAL;
using ReservationSystemModel;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            CustomerDAO customerDAO = new CustomerDAO();

            List<Customer> customers = customerDAO.GetAll();
            foreach (Customer customeren in customers)
            {
                Console.WriteLine(customeren);
            }
            Console.WriteLine();

            Console.Write("Enter customer id: ");
            int CustomerId =int.Parse(Console.ReadLine());

            Customer customer = customerDAO.GetById(CustomerId);

            if (customer != null)
            {
                Console.WriteLine(customer);
            }
            else
            {
                Console.WriteLine($"No Customer with id {CustomerId}");
            }
            Console.WriteLine();


            BookDAO BookDAO = new BookDAO();

            List<Book> books = BookDAO.GetAll();
            foreach (Book booken in books)
            {
                Console.WriteLine(booken);
            }
            Console.WriteLine();

            Console.Write("Enter book id: ");
            int BookId = int.Parse(Console.ReadLine());

            Book book = BookDAO.GetById(BookId);
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine($"No Customer with id {BookId}");
            }
        }
    }
}