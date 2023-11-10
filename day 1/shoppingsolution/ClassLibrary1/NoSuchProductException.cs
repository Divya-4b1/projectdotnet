using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    public class NoSuchProductException : Exception
    {
        string message;
        public NoSuchProductException()
        {
            message = "The product with teh given id is not present";
        }
        public override string Message => message;


    }
}
