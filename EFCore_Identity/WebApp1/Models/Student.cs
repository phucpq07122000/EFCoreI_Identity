using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? password { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;     
        public string Email { get; set; } = string.Empty;
    }
}
