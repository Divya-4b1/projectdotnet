using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLLibrary
{
    
        public class NoSuchDoctorException : Exception
        {
            string message;
            public NoSuchDoctorException()
            {
                message = "The doctor with the entered id is not present";
            }
            public override string Message => message;
        }
}
