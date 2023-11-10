using System.ComponentModel.DataAnnotations;

namespace FirstWebApplication.Models
{
    public class Customer
    {
        [Key]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
    }
}

