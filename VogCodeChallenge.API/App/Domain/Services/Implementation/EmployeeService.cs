using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.App.Domain.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(IEmployeeRepository employeeRepository)
        {

        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {

        }
    }
}
