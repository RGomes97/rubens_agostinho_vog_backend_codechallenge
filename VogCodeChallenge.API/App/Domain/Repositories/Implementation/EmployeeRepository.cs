using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.App.Domain.DataLoaders;

namespace VogCodeChallenge.API.App.Domain.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            List<Department> departmentList = EntityLoader.GetDefaultDepartments();
            List<Employee> employees = EntityLoader.GetDefaultEmployees(departmentList);

            return await Task.FromResult(employees);
        }

        public async Task<IList<Employee>> ListAllAsync()
        {
            List<Department> departmentList = EntityLoader.GetDefaultDepartments();
            List<Employee> employees = EntityLoader.GetDefaultEmployees(departmentList);

            return await Task.FromResult(employees);
        }

        
    }
}
