using System.Collections.Generic;
using FirstWebApplication.Models;

namespace FirstWebApplication.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomer(string email);
        List<Customer> GetAllCustomers();
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        void DeleteCustomer(string email);
        bool ValidateCredentials(string email, string password);
    }
}