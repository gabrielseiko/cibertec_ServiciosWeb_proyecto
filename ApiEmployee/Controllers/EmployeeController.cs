using ApiEmployee.Models;
using ApiEmployee.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmployee.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return StatusCode(StatusCodes.Status200OK,
                await employeeRepository.GetEmployees());
        }

        [HttpGet]
        [Route("GetEmployees/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK,
                await employeeRepository.GetEmployees(page, size));
        }

        [HttpGet]
        [Route("GetEmployeeById/{idEmployee}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int idEmployee)
        {
            return StatusCode(StatusCodes.Status200OK,
                await employeeRepository.GetEmployeeById(idEmployee));
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            return StatusCode(StatusCodes.Status201Created,
                await employeeRepository.CreateEmployee(employee));
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee employee)
        {
            return StatusCode(StatusCodes.Status200OK,
                await employeeRepository.UpdateEmployee(employee));
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public async Task<ActionResult<bool>> DeleteEmployee(int idEmployee)
        {
            return StatusCode(StatusCodes.Status200OK,
                await employeeRepository.DeleteEmployee(idEmployee));
        }
    }
}
