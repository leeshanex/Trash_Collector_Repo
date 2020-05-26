using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector_Proj.Data;
using TrashCollector_Proj.Models;

namespace TrashCollector_Proj.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            return View(loggedInCustomer);
        }

        // GET: Customers/Details/5
        public ActionResult Details()
        {
         
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
         
            if (loggedInCustomer == null)
            { 
                return NotFound();
            }

            return View(loggedInCustomer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
        
            return View(loggedInCustomer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                _context.Customer.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Details");
            }
           
            return View(customer);
        }

        // GET: Customers/Edit/5
        public  ActionResult Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
          
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
         
            return View(loggedInCustomer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                    var customerInDB = _context.Customer.Single(c => c.Id == customer.Id);
                    customerInDB.DayOfWeekPickUp = customer.DayOfWeekPickUp;
                    
                    _context.Update(customerInDB);
                    _context.SaveChanges();
            
                return RedirectToAction("Index", "Customers");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
