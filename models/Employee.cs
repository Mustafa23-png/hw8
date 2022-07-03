using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Employee Department")]
        [Required]
        public string Department { get; set;}
        [Display(Name = "Employee Email")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Employee Salary")]
        [Required]
        public decimal Salary { get; set; }

    }
}
