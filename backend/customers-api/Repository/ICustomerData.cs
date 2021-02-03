using customerApi.Model;
using System.Collections.Generic;

namespace customerApi.Data
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetCustomers();
    }
}