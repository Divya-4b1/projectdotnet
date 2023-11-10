using FirstWebApplication.Contexts;
using FirstWebApplication.Interfaces;
using FirstWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApplication.Repositories
{
    public class CustomerRepositoryDb : IRepository<string, Customer>
    {
        private readonly ShoppingContext _context;

        public CustomerRepositoryDb(ShoppingContext context)
        {
            _context = context;
        }

        public Customer Add(Customer item)
        {
            _context.Customers.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Customer Delete(string key)
        {
            var customer = Get(key);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Get(string key)
        {
            return _context.Customers.FirstOrDefault(c => c.Email == key);
        }

        public IList<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer Update(Customer item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}

