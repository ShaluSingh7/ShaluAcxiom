using ShaluAcxiom.Data;
using ShaluAcxiom.Models;
//using AakrityAcxiom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AakrityAcxiom.Controllers
{
    public class ReportController : Controller
    {
        private readonly AppDbContext _db;

        public ReportController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var vm = new ReportDashboardVM
            {
                TotalCustomers = _db.Customers.Count(),
                TotalEmployees = _db.Employees.Count(),

                RecentCustomers = _db.Customers
                                    .OrderByDescending(x => x.CustomerId)
                                    .Take(5)
                                    .ToList(),

                RecentEmployees = _db.Employees
                                    .OrderByDescending(x => x.EmployeeId)
                                    .Take(5)
                                    .ToList()
            };

            return View(vm);
        }
    }
}
