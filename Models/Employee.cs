using System.ComponentModel.DataAnnotations;

namespace ShaluAcxiom.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
