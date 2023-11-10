using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualifications { get; set; }
        public int Experience { get; set; }
        public double Fees { get; set; }

        public double phonenumber {  get; set; }
        public doctor()
        {
            Fees = 0.0f;
            phonenumber=1;
        }
        public doctor(int Id, string Name, string Qualifications, int Experience, double Fees, double phonenumber)
        {
            Id = Id;
            Name = Name;
            Qualifications = Qualifications;
            Experience = Experience;
            Fees = Fees;
            phonenumber = phonenumber;



        }
        public override string ToString()
        {
            return $"doctor Id : {Id}\ndoctor Name : {Name}\ndoctor Experience:  {Experience}\n doctor fees : Rs. {Fees}\n doctor phonenumber : {phonenumber}%\n doctor fees : {Fees}\n ";
        }
    }
}