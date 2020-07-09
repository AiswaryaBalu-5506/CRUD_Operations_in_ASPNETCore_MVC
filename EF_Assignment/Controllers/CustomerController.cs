using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Assignment.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Assignment.Controllers
{
    public class CustomerController : Controller
    {
        //gettting applicationdbContext to interact with SQL Server
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET all Customers
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = _db.Customer.ToList();
             return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer cust = _db.Customer.Find(id);
            return View(cust);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                _db.Customer.Add(c);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c = _db.Customer.Find(id);
            return View(c);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                _db.Customer.Update(c);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = _db.Customer.Find(id);
            return View(c);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                _db.Customer.Remove(c);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}