using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.App.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<IEnumerable<Employee>> GetAllByDepartmentId(Guid departmentId);
        Task<IList<Employee>> ListAllAsync();
    }
}