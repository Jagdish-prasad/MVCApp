using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller

    {
        private ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext
            dbContext)
        {
            this.dbContext = dbContext;
        }



        public IActionResult Index()
        {
            List<Employee>
                emps = dbContext.Employee.ToList();
            return View(emps);
        } 
        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employee.Add(emp);
                dbContext.SaveChanges();
                return RedirectToAction("index");

            }
            else
            {
                return View(emp);
            }
        }
        //Delete 
        public IActionResult Delete(int id)
        {
            var emp = dbContext.Employee.SingleOrDefault(e => e.Id == id);
            if(emp!=null)
            {
                dbContext.Employee.Remove(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        } 
        //Edit
        public IActionResult Edit (int id)
        {
            var emp = dbContext.Employee.SingleOrDefault(e => e.Id == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            dbContext.Employee.Update(emp);
            dbContext.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
