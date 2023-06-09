using ReservationSystemService;
using DALLayer;
using ModelLayer;
namespace assignment1
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing CustomerService");
            Console.ResetColor();

            Console.WriteLine();

            Console.Write("Enter customer id: ");
            int CustomerId = int.Parse(Console.ReadLine());

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


            BookDAO bookDAO = new BookDAO();
            BookService bookService = new BookService(bookDAO);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing BookService");
            Console.ResetColor();

            Console.WriteLine();

            Console.Write("Enter author name: ");
            string authorInput = Console.ReadLine();
            var booksByAuthor = bookService.GetByAurthor(authorInput);
             foreach (Book book in booksByAuthor) Console.WriteLine(book);
        }
    }
}