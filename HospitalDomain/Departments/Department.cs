using HospitalDomain.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Departments
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Department_Name { get; set; }
        public ICollection<Employee> Employees { get; set; }


    }
}
