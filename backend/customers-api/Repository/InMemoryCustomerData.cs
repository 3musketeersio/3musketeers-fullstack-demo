using customerApi.Data;
using customerApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace customerApi.Data
{
    public class InMemoryCustomerData : ICustomerData
    {
        private readonly List<Customer> customers;
        public InMemoryCustomerData()
        {
            customers = new List<Customer>()
            {
                new Customer { 
                    Id = 1, 
                    Name = "Jonathan Doe", 
                    Address = "Nguyen",
                    Email = "jonathan.doe@gmail.com",
                    HomePhone = "0295571100",
                    MobilePhone = "0489881033" 
                }
            };
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }
    }
}