using System.ComponentModel.DataAnnotations;

namespace ShaluAcxiom.Models
{
    public class UserLogin
    {
        
        public  string  Email { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
