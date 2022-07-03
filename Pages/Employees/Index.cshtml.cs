using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Data;
using EmployeeManagement.models;

namespace EmployeeManagement.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeManagement.Data.EmployeeManagementContext _context;

        public IndexModel(EmployeeManagement.Data.EmployeeManagementContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
