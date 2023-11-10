using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class managedoctor
    {
        doctor doctor;
        public managedoctor()
        {
            doctor = new doctor();
        }
        int generateId()
        {
            return new Random().Next(1, 100);
        }
        public void getdetailsfromuser()
        {
            doctor.Id = generateId();
            Console.WriteLine("Please enter the doctor name");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Please enter the doctor qualificatons");
            doctor.Qualifications = Console.ReadLine();
            Console.WriteLine("Please enter the doctor Experience");
            doctor.Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the fees of doctor");
            doctor.Fees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter doctor phone number");
            doctor.phonenumber= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("all the doctor details are generated\n");
        }
        public void PrintdoctorDetails()
        {
            Console.WriteLine(doctor);
            
        }
        public bool Updateexperience(int experience)
        {
            if (experience >= 0)
            {
                doctor.Experience = experience;
                return true;
                Console.WriteLine("experience updated");
            }
            return false;
            
        }
        public bool Updatephonenumber(int phonenumber)
        {
            if (phonenumber >= 0)
            {
                doctor.phonenumber = phonenumber;
                return true;
                Console.WriteLine("phonenumber updated");
            }
            return false;
            
        }
    }
}
