
using basicCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext dbContext;
        public EmployeeController(EmployeeDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var result = dbContext.Employees.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var emp = dbContext.Employees.Where(e => e.id == id).FirstOrDefault();
            return View(emp);
        }
        public IActionResult Edit(int id)
        {
            var emp = dbContext.Employees.Where(e => e.id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
           dbContext.Employees.Update(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var emp = dbContext.Employees.Where(e => e.id == id).FirstOrDefault();
            
            dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            
        } 
    }
}
