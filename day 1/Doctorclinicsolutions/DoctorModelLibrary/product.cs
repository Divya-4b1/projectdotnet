namespace DoctorModelLibrary
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Qualifications { get; set; } =string.Empty;
        public int Experience { get; set; }
        public double Fees { get; set; }

        public double phonenumber { get; set; }
        public product()
        {
            Fees = 0.0f;
            phonenumber = 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id">Doctor id</param>
        /// <param name="Name">Doctor name</param>
        /// <param name="Qualifications"> Doctor qualificatons</param>
        /// <param name="Experience">Doctor experience in years</param>
        /// <param name="Fees"> doctor fees in rs</param>
        /// <param name="phonenumber"> doctor mobile number</param>
        public product(int Id, string Name, string Qualifications, int Experience, double Fees, double phonenumber)
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
    
