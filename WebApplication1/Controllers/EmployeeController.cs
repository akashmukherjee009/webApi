using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Dtos;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext= dbContext;
        }

        //Read all employees
        public IActionResult GetAllEmployee()
        {
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }

        //Add employee
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto employeeDto)
        {
            var entityEntry = new Employee()
            {
                Name= employeeDto.Name,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone,
                Salary = employeeDto.Salary
            };
            dbContext.Employees.Add(entityEntry);
            dbContext.SaveChanges();
            return Ok(entityEntry);
        }
    }
}
