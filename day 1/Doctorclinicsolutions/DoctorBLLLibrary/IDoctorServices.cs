using DoctorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLLibrary
{
    public interface IDoctorServices
    {
        public product AddDoctor(product product);
        public product Updateexperience(int id, int experience);
        public product GetProduct(int id);
        public List<product> GetProducts();
        public product Updatephonenumber(int id, int phonenumber);
        public product Delete(int id);
    }
}
