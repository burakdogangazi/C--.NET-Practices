using AspNetCoreMvcIntroduction.Entities;
using System.Collections.Generic;

namespace AspNetCoreMvcIntroduction.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}