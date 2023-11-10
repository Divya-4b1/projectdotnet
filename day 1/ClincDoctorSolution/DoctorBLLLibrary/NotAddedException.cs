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
                message = "Doctor was not added.";
            }
            public override string Message => message;
        }
}
