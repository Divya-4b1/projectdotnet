namespace client
{
    internal class Program
    {
        managedoctor managedoctor;
        public Program()
        {
            managedoctor = new managedoctor();
        }
        void DisplayAdminMenu()
        {
            Console.WriteLine("1.Add doctor");
            Console.WriteLine("2.Modify doctor experience");
            Console.WriteLine("3.modify doctor phone number");
            Console.WriteLine("0.delete doctor");
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
                        Console.WriteLine("deleted");
                        break;
                    case 1:
                        managedoctor. getdetailsfromuser();
                        break;
                    case 2:
                        Updateexperience();
                        break;
                    case 3:
                        Updatephonenumber();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 0);
        }
        private void Updateexperience()
        {
            managedoctor.PrintdoctorDetails();
            Console.WriteLine("Please enter the new experience");
            int experience = Convert.ToInt32(Console.ReadLine());
            var result = managedoctor.Updateexperience(experience); 
            if (result == true)
            {
                Console.WriteLine("Experience updated");
                managedoctor.PrintdoctorDetails();
            }
            else
                Console.WriteLine("Unable to update experience");
        }
        private void Updatephonenumber()
        {
            managedoctor.PrintdoctorDetails();
            Console.WriteLine("Please enter the new phone number");
            int phonenumber = Convert.ToInt32(Console.ReadLine());
            var result = managedoctor.Updatephonenumber(phonenumber);
            if (result == true)
            {
                Console.WriteLine("phone number updated");
                managedoctor.PrintdoctorDetails();
            }
            else
                Console.WriteLine("Unable to update phone number");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the clinic");
            Program home =new Program();
            home.StartAdminActivities();
        }
    }
}