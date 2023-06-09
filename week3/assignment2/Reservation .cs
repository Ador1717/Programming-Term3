namespace assignment2
{
    internal class Reservation
    {
        public Customer Customer { get; set; }
        public List<Ticket> Ticket { get; set; }

        public Reservation(Customer customer)
        {
            Customer = customer;
            Ticket = new List<Ticket>();
        }
        public void AddTicket(Ticket ticket)
        {
            Ticket.Add(ticket);
        }
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (Ticket ticket in Ticket)
                {
                    if (Customer.Age >= ticket.MinumumAge)
                    {
                        double ticketPrice = ticket.Price;

                        if (ticket.Discount)
                        {
                            ticketPrice *= 0.95;
                        }
                        totalPrice += ticketPrice;
                        
                    }
                }
                if (Customer.Discount)
                {
                    totalPrice *= 0.9;
                }
                    return totalPrice;
                
            }

        }

    }
}
