using ShaluAcxiom.Models;

public class DashboardVM
{
    public List<Customer> Customers { get; set; }
    public List<Employee> Employees { get; set; }
    public List<DashboardVM> Reports { get; set; }
}
