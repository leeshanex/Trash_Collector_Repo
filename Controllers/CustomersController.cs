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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "FirstName");
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
                var customerCreate = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
                _context.Customer.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Details");
            }
            ViewBag.IdentityUserId = new SelectList(_context.Users, "Id", "FirstName", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var customerInDB = _context.Customer.Single(c => c.Id == customer.Id);
                    customerInDB.FirstName = customer.FirstName;
                    customerInDB.LastName = customer.LastName;
                    customerInDB.City = customer.City;
                    customerInDB.State = customer.State;
                    customerInDB.ZipCode = customer.ZipCode;
                    customerInDB.DayOfWeekPickUp = customer.DayOfWeekPickUp;
                    
                    _context.Update(customer);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }   
                return RedirectToAction("Index", "Customers");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "FirstName", customer.IdentityUserId);
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
