using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class ApplicationDbContext :DbContext 
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :
            base(options)
        { } 
        public DbSet<Location>Locations { get; set; }
         public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employee{ get; set; }
    }
}
