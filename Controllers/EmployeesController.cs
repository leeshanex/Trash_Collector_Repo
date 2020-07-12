using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using TrashCollector_Proj.Data;
using TrashCollector_Proj.Models;

namespace TrashCollector_Proj.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            return View();
        }

        // GET: Employees/Details/5
        public ActionResult Details()
        {
           
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            

            return View();
        }

        public ActionResult Profile()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            return View(loggedInEmployee);
        }
        public IActionResult FilterView(string dayOfWeek)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            DayOfWeek today = DateTime.Today.DayOfWeek;
            dayOfWeek = today.ToString();
            var filteredPickUps = _context.Customers.Where(c => c.ZipCode == loggedInEmployee.ZipCode && c.DayOfWeekPickUp == dayOfWeek);

            return View();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            return View(loggedInEmployee);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();


            return View(loggedInEmployee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            Customer customer = new Customer();
            if (ModelState.IsValid)
            {
              
            }
            
            return View();
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
