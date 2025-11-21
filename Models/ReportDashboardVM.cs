namespace ShaluAcxiom.Models
{
    public class ReportDashboardVM
    {
        public int TotalCustomers { get; set; }
        public int TotalEmployees { get; set; }

        public List<Customer> RecentCustomers { get; set; }
        public List<Employee> RecentEmployees { get; set; }
    }
}
