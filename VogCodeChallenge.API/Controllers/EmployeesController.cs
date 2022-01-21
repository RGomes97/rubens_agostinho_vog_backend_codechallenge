using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.App.Domain;
using VogCodeChallenge.API.App.Domain.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.GetAllAsync();
        }

        [HttpGet]
        [Route("department/{departmentId}")]
        //I'm using b2f029bd-e329-4691-8b78-3d2e6008a701 as departmentId to test
        public async Task<IEnumerable<Employee>> GetDepartment(Guid departmentId)
        {
            return await _employeeService.GetAllByDepartmentId(departmentId);
        }
    }
}
