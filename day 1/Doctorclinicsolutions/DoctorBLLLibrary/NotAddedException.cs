using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLLibrary
{
    public class NotAddedException : Exception
    {
        string message;
        public NotAddedException()
        {
            message = "Product was not addedd.";
        }
        public override string Message => message;

    }
}
