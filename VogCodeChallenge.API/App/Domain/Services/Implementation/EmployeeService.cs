using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.App.Domain.Repositories;

namespace VogCodeChallenge.API.App.Domain.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<IList<Employee>> ListAllAsync()
        {
            return await _employeeRepository.ListAllAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllByDepartmentId(Guid departmentId)
        {
            var employees = await this.ListAllAsync();
            return employees.Where(e => e.Departments.Any(c => c.Id == departmentId));
        }
    }
}
