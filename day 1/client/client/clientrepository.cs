//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace client
//{
//    internal class clientrepository
//    {
//            List<doctor> products;
//            public clientrepository()
//            {
//                products = new List<doctor>();
//            }
//        }
//    int GetNextId()
//    {
//        if (products.Count == 0)
//            return 1;
//        int id = products[products.Count - 1].Id;
//        return ++id;
//    }
//    void TakeRemainingdoctorDetails(doctor doctor)
//    {
//        Console.WriteLine("Please enter the doctor name");
//        doctor.Name = Console.ReadLine();
//        Console.WriteLine("Please enter the doctor qualificatons");
//        doctor.Qualifications = Console.ReadLine();
//        Console.WriteLine("Please enter the doctor Experience");
//        doctor.Experience = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Please enter the fees of doctor");
//        doctor.Fees = Convert.ToDouble(Console.ReadLine());
        
//    }
//    public doctor AddDoctor()
//    {
//        int id = GetNextId();
//        doctor pro = new doctor();
//        pro.Id = id;
//        //Getting the product details from theuser
//        TakeRemainingProductDetails(doctor);
//        //Adding to the collection
//        doctor.AddDoctor(product);
//        return product;
//    }
//    public List<doctor> GetProducts()
//    {
//        return product;
//    }
//}
