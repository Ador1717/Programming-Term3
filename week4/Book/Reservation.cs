using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemModel;

public class Reservation
{
    private int id;
    public int Id { get { return id; } set { id = value; } }
    public DateTime ReservationDateTime { get; set; }
    public Customer Customer { get; set; }
    public Book Book { get; set; }


    public Reservation(int id, Customer customer, Book book)
    {
        Id = id;
        Customer = customer;
        Book = book;
    }

    public override string ToString()
    {
        return $"{Customer.FullName} ({Customer.EmailAddress}) -> '{Book.Title}' by {Book.Author}";
    }       
}

