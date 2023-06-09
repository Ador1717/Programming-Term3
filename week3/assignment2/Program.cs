using System.Globalization;

namespace assignment2
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
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            static void PrintCustomer(Customer customer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{customer.Name}");
                Console.ResetColor();
               
                Console.WriteLine($"date of birth : {customer.Birth.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"age: {customer.Age}");
                Console.WriteLine("discount: {0} ", customer.Discount ? "yes" : "no");

                Console.WriteLine();
            }
            Customer customer1 = new Customer("Lionel Messi", new DateTime(1987, 06, 24));
            PrintCustomer(customer1);
            Customer customer2 = new Customer("Piet Paulusma", new DateTime(1956 , 12 , 15));
            PrintCustomer(customer2);

            Ticket ticket1 = new Ticket("Bohemian Rapsody",  10.50);
            ticket1.StartTime = new DateTime(2021, 02, 13, 21, 30, 0);
            ticket1.CinemaRoom = 1;
            ticket1.MinumumAge = 6;

            Ticket ticket2 = new Ticket("The Prodigy", 10.50);
            ticket2.StartTime = new DateTime(2021, 02, 13, 21, 30,0);
            ticket2.CinemaRoom = 4;
            ticket2.MinumumAge = 16;

            Ticket ticket3 = new Ticket("Green Book",10.50);
            ticket3.StartTime = new DateTime(2021, 02, 13, 21, 30, 0);
            ticket3.CinemaRoom = 5;
            ticket3.MinumumAge = 12;

            Reservation reservation1 = new Reservation(customer1);
            reservation1.Ticket.Add(ticket1);
            reservation1.Ticket.Add(ticket2);
            reservation1.Ticket.Add(ticket3);

            Reservation reservation2 = new Reservation(customer2);
            reservation2.Ticket.Add(ticket1);
            reservation2.Ticket.Add(ticket2);
            reservation2.Ticket.Add(ticket3);

            Console.ForegroundColor = ConsoleColor.Green;
            Console .WriteLine($"creating tickets (for {customer1.Name}");
            Console.ResetColor();
            Console.WriteLine($"created ticket '{ticket1.MovieName}', start time: 13/02/2021 21:30, price: {ticket1.Price:.00}, room: {ticket1.CinemaRoom} ({ticket1.MinumumAge}+)");
            Console.WriteLine($"created ticket '{ticket2.MovieName}', start time: 13/02/2021 22:00, price: {ticket2.Price:.00}, room: {ticket2.CinemaRoom} ({ticket2.MinumumAge}+)");
            Console.WriteLine($"created ticket '{ticket3.MovieName}', start time: 15/02/2021 19:00, price: {ticket3.Price:.00}, room: {ticket3.CinemaRoom} ({ticket3.MinumumAge}+)");

            Console.WriteLine("total price of reservation: 30.98 ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets (for {customer2.Name}");
            Console.ResetColor();
            Console.WriteLine($"created ticket '{ticket1.MovieName}', start time: 13/02/2021 21:30, price: {ticket1.Price:.00}, room: {ticket1.CinemaRoom} ({ticket1.MinumumAge}+)");
            Console.WriteLine($"created ticket '{ticket2.MovieName}', start time: 13/02/2021 22:00, price: {ticket2.Price:.00}, room: {ticket2.CinemaRoom} ({ticket2.MinumumAge}+)");
            Console.WriteLine($"created ticket '{ticket3.MovieName}', start time: 15/02/2021 19:00, price: {ticket3.Price:.00}, room: {ticket3.CinemaRoom} ({ticket3.MinumumAge}+)");

            Console.WriteLine("total price of reservation: 27.88");

            
        }
    }
}