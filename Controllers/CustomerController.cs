using ShaluAcxiom.Data;
using ShaluAcxiom.Models;
using Microsoft.AspNetCore.Mvc;

namespace AakrityAcxiom.Controllers
{
    public class CustomerController:Controller
    {
        private readonly AppDbContext _db;

        public CustomerController(AppDbContext db)
        {
            _db = db;
        }

        // =======================
        // 1. SHOW ALL EMPLOYEES
        // =======================
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            return View(customers);
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
        public IActionResult Create(Customer cus)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(cus);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cus);
        }

        // =======================
        // 4. EDIT (GET)
        // =======================
        public IActionResult Edit(int id)
        {
            var cus = _db.Customers.Find(id);

            if (cus == null)
                return NotFound();

            return View(cus);
        }

        // =======================
        // 5. EDIT (POST)
        // =======================
        [HttpPost]
        public IActionResult Edit(Customer cus)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Update(cus);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cus);
        }

        // =======================
        // 6. DETAILS (READ)
        // =======================
        public IActionResult Details(int id)
        {
            var cus = _db.Customers.Find(id);

            if (cus == null)
                return NotFound();

            return View(cus);
        }

        // =======================
        // 7. DELETE (GET Confirmation)
        // =======================
        public IActionResult Delete(int id)
        {
            var cus = _db.Customers.Find(id);

            if (cus == null)
                return NotFound();

            return View(cus);
        }

        // =======================
        // 8. DELETE (POST)
        // =======================
        [HttpPost]
        public IActionResult DeleteConfirmed(int CustomerId)
        {
            var cus = _db.Customers.Find(CustomerId);

            if (cus == null)
                return NotFound();

            _db.Customers.Remove(cus);
            _db.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}
