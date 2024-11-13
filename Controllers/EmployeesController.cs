using AssetManagementSystem.Models;
using AssetManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> employees = _service.GetAllEmployees();
            return Ok(employees);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee employee = _service.GetEmployeeById(id);
            return Ok(employee);

        }
        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            int Result = _service.AddNewEmployee(employee);
            return Ok(Result);
        }
        [HttpPut]
        public IActionResult PutEmployee(Employee employee)
        {
            string result = _service.UpdateEmployee(employee);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            string result = _service.DeleteEmployee(id);
            return Ok(result);
        }
    }

}
