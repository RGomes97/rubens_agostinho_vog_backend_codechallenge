using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.App.Domain.DataLoaders
{
    public static class EntityLoader
    {
        public static List<Employee> GetDefaultEmployees(List<Department> departmentList)
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    Address = "Address Test1",
                    Departments = departmentList,
                    FirstName = "FirstName Test 1",
                    LastName = "LastName Test 1",
                    JobTitle = "Job Title 1"
                },
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    Address = "Address Test2",
                    Departments = departmentList,
                    FirstName = "FirstName Test 2",
                    LastName = "LastName Test 2",
                    JobTitle = "Job Title 2"
                }
            };
        }

        public static List<Department> GetDefaultDepartments()
        {
            return new List<Department>()
            {
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Address = "Address Test 2",
                    Name = "Name test 2"
                },
                new Department()
                {
                    Id = Guid.NewGuid(),
                    Address = "Address Test 2",
                    Name = "Name test 2"
                }
            };
        }
    }
}
