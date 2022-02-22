using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class Employee 
    {
        public int Id { get; set; }
        [Display(Name="Employee Name")] 
        [Required(ErrorMessage ="Employee Name can't Empty !")]
        [MinLength( 3,ErrorMessage = "Name must be  min 3 char !")]
        [MaxLength(20, ErrorMessage = "Name must be  max 20 char !")]
        public string Name { get; set; }
        [Display(Name= "Employee Email Address")]
        [Required(ErrorMessage = "Employee Email can't Empty !")] 
        [EmailAddress(ErrorMessage ="Email Address is not valid !")]
        public string Email { get; set; }
        [Display(Name = "Employee Mobile")]
        [Required(ErrorMessage = "Employee Mobile can't Empty !")] 
        [RegularExpression(@"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", 
            ErrorMessage ="Invalid Mobile number !")]
        public string Mobile { get; set; }
        [Display(Name = "Employee Address")]
        [Required(ErrorMessage = "Employee Address can't Empty !")] 
        [MaxLength(200,ErrorMessage ="Max 200 char!")]
        public string Address { get; set; }
    }
}
