using FirstWebApplication.Interfaces;
using FirstWebApplication.Models;
using System.Collections.Generic;

public class CustomerService : ICustomerService
{
    private readonly IRepository<string, Customer> _customerRepository;

    public CustomerService(IRepository<string, Customer> customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer GetCustomer(string email)
    {
        return _customerRepository.Get(email);
    }

    public List<Customer> GetAllCustomers()
    {
        return _customerRepository.GetAll().ToList();
    }

    public Customer CreateCustomer(Customer customer)
    {
        return _customerRepository.Add(customer);
    }

    public Customer UpdateCustomer(Customer customer)
    {
        return _customerRepository.Update(customer);
    }

    public void DeleteCustomer(string email)
    {
        _customerRepository.Delete(email);
    }

    public bool ValidateCredentials(string email, string password)
    {
        var customer = GetCustomer(email);
        return customer != null && customer.Password == password;
    }
}
