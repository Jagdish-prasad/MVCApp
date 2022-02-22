using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Controllers;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> Locations = dbContext.Locations.ToList();
            return View(Locations);
        } 
        //Change code for link
        public IActionResult CustomerList(int id)
        {
            List<Customer> customers =
                dbContext.Customers.Where(e => e.Location.Id == id).ToList();
            return View(customers);
                
        }
    }
}
