using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.App.Domain.DataLoaders;

namespace VogCodeChallenge.API.App.Domain.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //to implement a database i would like to use a dbContext from entityframework to access the database and manipulate the data like this:
        //public EmployeeRepository(VogCodeChallengeContext context)
        //{
        //    _dbContext = context;
        //}
        //To do it like this I just would have to Map my database Models and use like this
        //public async Task<IEnumerable<Employee>> GetAllAsync()
        //{
        //    return await context.Employees.ToListAsync();
        //}
        //public async Task<IList<Employee>> ListAllAsync()
        //{
        //    return await context.Employees.ToListAsync();
        //}

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var departmentList = EntityLoader.GetDefaultDepartments();
            var employees = EntityLoader.GetDefaultEmployees(departmentList);

            return await Task.FromResult(employees);
        }

        public async Task<IList<Employee>> ListAllAsync()
        {
            var departmentList = EntityLoader.GetDefaultDepartments();
            var employees = EntityLoader.GetDefaultEmployees(departmentList);

            return await Task.FromResult(employees);
        }

        
    }
}
