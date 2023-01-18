using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Employees
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        public string Type_Name { get; set; }
        public ICollection<Employee> Employees { get; set;}
    }
}
