using ShaluAcxiom.Data;
using ShaluAcxiom.Models;
using Microsoft.AspNetCore.Mvc;


public class EmployeeController : Controller
{
    private readonly AppDbContext _db;

    public EmployeeController(AppDbContext db)
    {
        _db = db;
    }

    // =======================
    // 1. SHOW ALL EMPLOYEES
    // =======================
    public IActionResult Index()
    {
        var employees = _db.Employees.ToList();
        return View(employees);
    }

    // =======================
    // 2. CREATE (GET)
    // =======================
    public IActionResult Create()
    {
        return View();
    }

    // =======================
    // 3. CREATE (POST)
    // =======================
    [HttpPost]
    public IActionResult Create(Employee emp)
    {
        if (ModelState.IsValid)
        {
            _db.Employees.Add(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(emp);
    }

    // =======================
    // 4. EDIT (GET)
    // =======================
    public IActionResult Edit(int id)
    {
        var emp = _db.Employees.Find(id);

        if (emp == null)
            return NotFound();

        return View(emp);
    }

    // =======================
    // 5. EDIT (POST)
    // =======================
    [HttpPost]
    public IActionResult Edit(Employee emp)
    {
        if (ModelState.IsValid)
        {
            _db.Employees.Update(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(emp);
    }

    // =======================
    // 6. DETAILS (READ)
    // =======================
    public IActionResult Details(int id)
    {
        var emp = _db.Employees.Find(id);

        if (emp == null)
            return NotFound();

        return View(emp);
    }

    // =======================
    // 7. DELETE (GET Confirmation)
    // =======================
    public IActionResult Delete(int id)
    {
        var emp = _db.Employees.Find(id);

        if (emp == null)
            return NotFound();

        return View(emp);
    }

    // =======================
    // 8. DELETE (POST)
    // =======================
    [HttpPost]
    public IActionResult DeleteConfirmed(int EmployeeId)
    {
        var emp = _db.Employees.Find(EmployeeId);

        if (emp == null)
            return NotFound();

        _db.Employees.Remove(emp);
        _db.SaveChanges();

        return RedirectToAction("Index","Employee");
    }
}
