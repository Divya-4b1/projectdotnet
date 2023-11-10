using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorModelLibrary;

namespace DoctorDALLibrary
{
    public interface IRepository
    {
        public product Add(product product);
        public product Update(product product);
        public product Delete(int id);
        public product GetById(int id);
        public List<product> GetAll();
    }
}
