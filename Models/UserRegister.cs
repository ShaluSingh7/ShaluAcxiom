using System.ComponentModel.DataAnnotations;

namespace ShaluAcxiom.Models
{
    public class UserRegister
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
