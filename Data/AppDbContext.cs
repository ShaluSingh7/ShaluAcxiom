using ShaluAcxiom.Models;
//using AakrityAcxiom.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ShaluAcxiom.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        public DbSet<UserRegister> userRegisters { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Report> Reports { get; set; }
        //public DbSet<ReportDashboarVM> ReportsNews { get; set; }
        //public DbSet<ReportDashboardVM> ReportsTable { get; set; }

    }
}
