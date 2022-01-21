using System.Collections.Generic;

namespace VogCodeChallenge.API.App.Domain
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; } //I could add Address to baseEntity since both classes are using
        public virtual ICollection<Department> Departments { get; set; }
    }
}
