using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLLibrary
{
    
        public class NoDoctorsAvailableException : Exception
        {
            string message;
            public NoDoctorsAvailableException()
            {
                message = "No doctors are available currently";
            }
            public override string Message => message;
        }
}
