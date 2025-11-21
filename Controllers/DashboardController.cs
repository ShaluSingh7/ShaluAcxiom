//using AakrityAcxiom.Data;
//using AakrityAcxiom.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//public class DashboardController : Controller
//{
//    private readonly AppDbContext _context;

//    public DashboardController(AppDbContext context)
//    {
//        _context = context;
//    }
//    public IActionResult UserDashboard()
//    {
//        // Check if session available
//        if (HttpContext.Session.GetString("UserName") == null)
//        {
//            return RedirectToAction("Login", "Authentication");
//        }

//        return View();
//    }

//}


//using AakrityAcxiom.Data;
//using AakrityAcxiom.Models;
////using AakrityAcxiom.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//public class DashboardController : Controller
//{
//    private readonly AppDbContext _context;

//    public DashboardController(AppDbContext context)
//    {
//        _context = context;
//    }

//    public IActionResult UserDashboard()
//    {
//        // Check if session available
//        if (HttpContext.Session.GetString("UserName") == null)
//        {
//            return RedirectToAction("Login", "Authentication");
//        }

//        return View();
//    }

//    // =============================
//    // 🔍 SEARCH FUNCTIONALITY
//    // =============================
//    public IActionResult Search(string query)
//    {
//        if (string.IsNullOrWhiteSpace(query))
//        {
//            // Empty search to avoid error
//            return View(new SearchViewModel());
//        }

//        var vm = new SearchViewModel
//        {
//            Customers = _context.Customers
//                        .Where(x => x.CustomerName.Contains(query))
//                        .ToList(),

//            Employees = _context.Employees
//                        .Where(x => x.EmployeeName.Contains(query))
//                        .ToList(),

//            //Reports = _context.Reports
//            //            .Where(x => x.ReportTitle.Contains(query))
//            //            .ToList()
//        };

//        return View(vm);
//    }
//}

using ShaluAcxiom.Data;
using ShaluAcxiom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DashboardController : Controller
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult UserDashboard(string query)
    {
        // Session check
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return RedirectToAction("Login", "Authentication");
        }

        var vm = new SearchViewModel();

        // Search work
        if (!string.IsNullOrWhiteSpace(query))
        {
            vm.Customers = _context.Customers
                .Where(x => x.CustomerName.Contains(query))
                .ToList();

            vm.Employees = _context.Employees
                .Where(x => x.EmployeeName.Contains(query))
                .ToList();

            ViewBag.Search = query;
        }

        return View(vm);
    }
}


