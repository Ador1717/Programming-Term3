using ModelLayer;
using DALLayer;
namespace ReservationSystemService
{
    public class CustomerService
    {
        private readonly CustomerDAO customerDAO;
        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }
        public Customer GetById(int CustomerId)
        {
            return customerDAO.GetById(CustomerId);
        }
    }
}