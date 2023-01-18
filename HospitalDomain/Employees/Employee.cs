using HospitalDomain.Departments;
using HospitalDomain.Hospitals;
using HospitalDomain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Employees
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string First_Name { get; set; }
        public string Middle_Name { get; set;}
        public string Last_Name { get; set; }
        public Int64 Mobile_No { get; set; }
        public string Email { get; set;}
        public Int64 Alternate_No { get; set;}
        public string Gender { get; set;}   
        public DateTime Join_Date { get; set; }
        public DateTime Created_Date { get; set;}
        public int Creator_Id { get; set; }
        public EmployeeType EmployeeTypes { get; set; }
        public ICollection<Department> Departments { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Service> Services { get; set; }

    }
}
