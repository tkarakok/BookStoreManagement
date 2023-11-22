using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetEmployees();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }

        [HttpGet("getemployeedetails")]
        public IActionResult GetEmployeeDetails()
        {
            var result = _employeeService.GetEmployeeDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }
    }
}
