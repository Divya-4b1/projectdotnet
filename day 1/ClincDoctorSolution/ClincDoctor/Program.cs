using System.Numerics;


using DoctorBLLLibrary;
using DoctorModelLibrary;
namespace CliniDoctor
    {
        internal class Program
        {
            IDoctorService DoctorService;
            public Program()
            {
                DoctorService = new DoctorService();
            }
            void DisplayAdminMenu()
            {
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. update Doctor Phone Number");
                Console.WriteLine("3. update Doctor Experiece");
                Console.WriteLine("4. Show all doctors");
                Console.WriteLine("5. Delete Doctor ");
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
                            Console.WriteLine("Exit");
                            break;
                        case 1:
                            AddDoctor();
                            break;
                        case 2:
                            DoctorPhoneUpdate();
                            break;
                        case 3:
                            DoctorExperienceUpdate();
                            break;
                        case 4:
                            ShowAllDoctors();
                            break;
                        case 5:
                            RemoveDoctor();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (choice != 0);
            }
            void AddDoctor()
            {
                try
                {
                    Doctor doctor = TakeDoctorDetails();
                    var result = DoctorService.AddDoctor(doctor);
                    if (result != null)
                    {
                        Console.WriteLine("Doctor Added");
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
            Doctor TakeDoctorDetails()
            {
                Doctor doctor = new Doctor();
                Console.WriteLine(" enter doctor name");
                doctor.Name = Console.ReadLine();
            thispoint:
                Console.WriteLine(" enter doctor phone number");
                doctor.DoctorNumber = Convert.ToInt64(Console.ReadLine());
                string numberString = doctor.DoctorNumber.ToString();
                int numberOfDigits = numberString.Length;
                if (numberOfDigits != 10)
                {
                    Console.WriteLine("Please enter a valid number");
                    goto thispoint;
                }
                Console.WriteLine("enter doctor speciality");
                doctor.DoctorSpeciality = Console.ReadLine();
                Console.WriteLine("enter doctor experience in years");
                doctor.DoctorExperience = Convert.ToInt32(Console.ReadLine());
                return doctor;
            }
            int GetDoctorIdFromUser()
            {
                int id;
                Console.WriteLine(" enter the doctor id");
                id = Convert.ToInt32(Console.ReadLine());
                return id;
            }
            private void DoctorPhoneUpdate()
            {
                var id = GetDoctorIdFromUser();
                Console.WriteLine(" enter the new phone number");
                long doctorNumber = Convert.ToInt64(Console.ReadLine());
                Doctor doctor = new Doctor();
                doctor.DoctorNumber = doctorNumber;
                doctor.Id = id;
                try
                {
                    var result = DoctorService.UpdateContactNumber(id, doctorNumber);
                    if (result != null)
                        Console.WriteLine("Update Complete");
                }
                catch (NoSuchDoctorException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            private void DoctorExperienceUpdate()
            {
                var id = GetDoctorIdFromUser();
                Console.WriteLine(" enter the doctor new experience in years");
                int doctorExperience = Convert.ToInt32(Console.ReadLine());
                Doctor doctor = new Doctor();
                doctor.DoctorExperience = doctorExperience;
                doctor.Id = id;
                try
                {
                    var result = DoctorService.UpdateExperience(id, doctorExperience);
                    if (result != null)
                        Console.WriteLine("Updation Complete");
                }
                catch (NoSuchDoctorException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            private void ShowAllDoctors()
            {
                Console.WriteLine("***********************************");
                var doctors = DoctorService.GetDoctor();
                foreach (var item in doctors)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("-------------------------------");
                }
                Console.WriteLine("***********************************");
            }
            private void RemoveDoctor()
            {
                try
                {
                    int id = GetDoctorIdFromUser();
                    if (DoctorService.Delete(id) != null)
                        Console.WriteLine("Removed");
                }
                catch (NoSuchDoctorException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void Main(string[] args)
            {
               
                Program home = new Program();
                home.StartAdminActivities();
                Console.WriteLine("hello world");
        }
        }
    }
    
