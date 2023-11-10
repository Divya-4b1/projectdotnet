using DoctorDALLibrary;
using DoctorModelLibrary;
using DoctorBLLLibrary;

namespace DoctorClinics
{
    internal class Program
    {
        IDoctorServices doctorsevices;
        public Program()
        {
            DoctorServices = new DoctorServices();
        }
        void DisplayAdminMenu()
        {
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Phone number");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Print All details");
            Console.WriteLine("0. Exit");
        }
        void StartAdminActivities()
        {
            int choice;
            do
            {
                DisplayAdminMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye bye");
                        break;
                    case 1:
                        AddDoctor();
                        break;
                    case 2:
                        Updatephonenumber();
                        break;
                    case - 3:
                        updateexprience();
                    case 4:
                        DeleteProduct();
                        break;
                    case 5:
                        PrintAllProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 0);
        }
        private void PrintAllProducts()
        {
            Console.WriteLine("***********************************");
            var products = doctorServices.GetProducts();
            foreach (var item in products)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("***********************************");
        }
        void AddDoctor()
        {
            try
            {
                product product = TakeProductDetails();
                var result = doctorsevices.AddDoctor(product);
                if (result != null)
                {
                    Console.WriteLine("Product added");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (NotAddedException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        product TakeProductDetails()
        {
            product product = new product();
            Console.WriteLine("Please enter the product name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter the product price");
            product.Qualifications = Console.ReadLine();
            Console.WriteLine("Please enter the product quantity");
            product.Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the product description");
            product.phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the product discount that you can offer");
            product.Fees = Convert.ToInt32(Console.ReadLine());
            
            return product;
        }
        int GetProductIdFromUser()
        {
            int id;
            Console.WriteLine("Please enter the product id");
            id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        private void DeleteProduct()
        {
            try
            {
                int id = GetProductIdFromUser();
                if (doctorServices.Delete(id) != null)
                    Console.WriteLine("Product deleted");
            }
            catch (NoSuchProductException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void Updatephonenumber()
        {
            var id = GetProductIdFromUser();
            Console.WriteLine("Please enter the new price");
            float price = Convert.ToSingle(Console.ReadLine());
            product product = new product();
            product.Price = price;
            product.Id = id;
            try
            {
                var result = doctorService.UpdateProductPrice(id, price);
                if (result != null)
                    Console.WriteLine("Update success");
            }
            catch (NoSuchProductException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int Main(string[] args)
        {
            Program program = new Program();
            program.StartAdminActivities();
            Console.WriteLine("Hello, World!");
            return 0;
        }
    }
}

    }

}
