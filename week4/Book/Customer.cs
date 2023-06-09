using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemModel
{
    public class Customer
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string FullName { get { return $"{FirstName} {LatName}"; } }
        public string EmailAddress { get; set; }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LatName = lastName;
            EmailAddress = emailAddress;
        }
        public override string ToString()
        {
            return $"{FullName} ({EmailAddress})";
        }
    }
}
