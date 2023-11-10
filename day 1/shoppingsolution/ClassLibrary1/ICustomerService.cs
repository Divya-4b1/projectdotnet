using Shoppingmodellibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingbLL_library
{
    public interface ICustomerService
    {
        public Customer Register(Customer customer);
        public bool Login(string username, string password);
    }
}
