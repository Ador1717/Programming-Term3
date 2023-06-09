using ReservationSystemModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationDAL
{
    public class CustomerDAO
    {
        private readonly SqlConnection connection;

        public CustomerDAO()
        {
            string connstring = ConfigurationManager
                            .ConnectionStrings["SomerenDatabase"]
                            .ConnectionString;
            connection = new SqlConnection(connstring);
        }
        public List<Customer> GetAll()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = ReadCustomer(reader);
                customers.Add(customer);
            }
            reader.Close();
            connection.Close();
            return customers;
        }
        public Customer GetById(int CustomerId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE Id = @Id", connection);

            cmd.Parameters.AddWithValue("@Id", CustomerId);

            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;

            if (reader.Read())
            {
                customer = ReadCustomer(reader);
            }
            reader.Close();
            connection.Close();

            return customer;
        }
        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAddress = (string)reader["EmailAddress"];

            return new Customer(id, firstName, lastName, emailAddress);
        }
    }
}
