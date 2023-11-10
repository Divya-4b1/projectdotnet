using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLLibrary
{
    public class NoProductsAvailableException : Exception
    {
        string message;
        public NoProductsAvailableException()
        {
            message = "No products are available currently";
        }

        public override string Message => message;
    }
}
