using System.Collections.Generic;

namespace VogCodeChallenge.API.App.Domain
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
